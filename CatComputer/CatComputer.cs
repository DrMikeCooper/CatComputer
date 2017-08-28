using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CatComputer
{
    class CatComputer
    {
        // settings to feed into the battle computer for each run
        public int numSessions = 380;
        public float pWander = 33.3f; // chance of each cat wandering instead of playing
        public CatData data = new CatData();
        int catCost = 1000;

        public int level = 0;
        public int numCats = 1; // number of cats we own
        List<float> toys = new List<float>(); //array of xp multipliers for the toys we own, keep this sorted
        int xp; // earned by playing with cats. Automatically levels you up and opens up new rooms 
        int coin; // money
        int hardware; // todo subdivide this later into screws, wood etc.
        int sessionNumber;

        // other useful stuff
        Random dice = new Random();

        // data arrays
        public int[] coinHistory;
        public int[] hardwareHistory;
        public int[] coinNeedHistory;
        public int[] hardwareNeedHistory;
        public int[] xpHistory;
        public int[] levelHistory;
        public int[] catsHistory;
        public int[] roomsHistory;
        public int[] roomsHistory2;
        public List<string> events = new List<string>();

        // do the entire run
        public void Run()
        {
            data.LoadRooms();

            level = 0;
            numCats = 1;

            // lock all rooms except the first
            bool first = true;
            for (int i=0; i< data.rooms.Length; i++)
            {
                data.rooms[i].unlocked = first;
                data.rooms[i].useable = first;
                first = false;
            }

            events.Clear();
            toys.Clear();
            xp = 0;
            coin = 0;
            hardware = 0;
            events.Clear();

            coinHistory = new int[numSessions];
            hardwareHistory = new int[numSessions];
            coinNeedHistory = new int[numSessions];
            hardwareNeedHistory = new int[numSessions];
            xpHistory = new int[numSessions];
            levelHistory = new int[numSessions];
            catsHistory = new int[numSessions];
            roomsHistory = new int[numSessions];
            roomsHistory2 = new int[numSessions];

            StreamWriter file = new StreamWriter("Log.csv");
            file.WriteLine("Session,Level,Rooms,Cats,Coin,Hardware, XP");
            for (int i = 0; i < numSessions; i++)
            {
                sessionNumber = i+1;
                RunSession();
                file.WriteLine("" + i +"," +  level + "," + GetNumRooms() + "," + numCats + "," + coin + "," + hardware + "," + xp);
                coinHistory[i] = coin;
                hardwareHistory[i] = hardware;
                xpHistory[i] = xp;
                levelHistory[i] = level;
                catsHistory[i] = numCats;
                roomsHistory[i] = GetNumRooms();
                roomsHistory2[i] = GetNumRooms(true);
                coinNeedHistory[i] = GetCoinNeed();
                hardwareNeedHistory[i] = GetHWNeed();
            }
            file.Close();
        }

        // simulate a single play session
        public void RunSession()
        {
            float toyMultiplier = 1.0f;
            int toyIndex = 0;

            for (int i = 0; i < numCats; i++)
            {
                if (dice.Next(0, 100) < pWander)
                {
                    Wander();
                }
                else
                {
                    if (toyIndex < toys.Count)
                    {
                        toyMultiplier = toys[toyIndex];
                        toyIndex++;
                    }
                    Play(toyMultiplier);
                }
            }
            SpendResources();
        }

        // accumulate passive XP per cat
        void PassiveXP()
        {
            for (int i = 0; i < numCats; i++)
            {
                xp += data.passiveXP;
                coin += data.passiveCoin;
            }

        }

        // a single cat playing with the toys in it's room
        void Play(float multiplier)
        {
            // multiply by level perhaps?
            xp += (int)(data.activeXP * multiplier);
            coin += (int)(data.activeCoin * multiplier);
        }

        // a single cat going for a neighbourhood wander
        void Wander()
        {
            // accumulate hardware
            if (dice.Next(0,100) < data.pctWanderHardware)
                hardware += data.wanderHardware; 
            if (dice.Next(0,100) < data.pctWanderCoin)
                coin += data.wanderCoin;

            // might pick up a new cat if we have space
            if (dice.Next(0, 100) < data.pctNewCat )
            {
                if (numCats < CatCapacity())
                {
                    // numCats++;
                    // events.Add("" + sessionNumber + ": Found a cat!");
                    // this costs coin
                }
                else
                {
                    //events.Add("" + sessionNumber + ": Turned away a stray!");
                }
            }
        }

        // do what a good player would do with their coin and resources
        void SpendResources()
        {
            int catPrice = catCost * numCats;
            // can we buy a new cat - increase this cost per cat we own
            if (numCats < CatCapacity() && coin > catPrice)
            {
                coin -= catPrice;
                numCats++;
                events.Add("" + sessionNumber + ": Bought a cat!");
            }

            // automatic - have we levelled up?
            if (xp > data.GetXpForLevel(level))
            {
                level++;
                // TODO - level up bonuses, coins, gems, resources

                // automatic - have we unlocked a new room by levelling?
                for (int i = 0; i < data.rooms.Length; i++)
                {
                    if (level == data.rooms[i].unlockLevel)
                    {
                        events.Add("" + sessionNumber + ": Room " + i + " unlocked!");
                        data.rooms[i].unlocked = true;
                    }
                }
            }

            // check replacing our crappest toys with better ones which unlock with level.
            float rank = data.GetToyMultForLevel(level);
            int cost = data.GetToyCost(rank);

            if (toys.Count < numCats)
            {
                if (cost < coin)
                {
                    coin -= cost;
                    toys.Add(rank);
                    toys.Sort();
                    toys.Reverse();
                    events.Add("" + sessionNumber + ": Bought Toy " + rank);
                }
            }
            else
            {
                if (rank > toys[toys.Count - 1])
                {
                    if (cost < coin)
                    {
                        float oldRank = toys[toys.Count - 1];
                        coin -= cost;
                        toys[toys.Count - 1] = rank;
                        toys.Sort();
                        toys.Reverse();
                        events.Add("" + sessionNumber + ": Replaced Toy " + oldRank + "->" + rank);
                    }
                }
            }

            // automatic - subtract hardware to unlock new room
            for (int i = 0; i < data.rooms.Length; i++)
            {
                CatData.Room r = data.rooms[i];
                if (r.unlocked && !r.useable && coin >= r.coinToReno && hardware >= r.hardwareToReno)
                {
                    coin -= r.coinToReno;
                    hardware -= r.hardwareToReno;
                    data.rooms[i].useable = true;
                    events.Add("" + sessionNumber + ": Room " + i + " finished!");
                    break;
                }
            }
        }

        // HELPER FUNCTIONS
        int CatCapacity()
        {
            int count = 0;
            foreach (CatData.Room r in data.rooms)
            {
                if (r.useable)
                    count+=r.numCats;
            }
            return count;
        }

        public int GetNumRooms(bool countLocked = false)
        {
            int count = 0;
            foreach (CatData.Room r in data.rooms)
            {
                if (r.useable || (countLocked && r.unlocked))
                    count++;
            }
            return count;
        }

        int GetCoinNeed()
        {
            int count = 0;
            foreach (CatData.Room r in data.rooms)
            {
                if (!r.useable && r.unlocked)
                    count += r.coinToReno;
            }
            return count;
        }

        int GetHWNeed()
        {
            int count = 0;
            foreach (CatData.Room r in data.rooms)
            {
                if (!r.useable && r.unlocked)
                    count += r.hardwareToReno;
            }
            return count;
        }

    }
}
