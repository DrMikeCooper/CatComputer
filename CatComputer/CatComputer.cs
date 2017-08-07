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
        public int numSessions = 100;
        public float pWander = 33.3f; // chance of each cat wandering instead of playing
        CatData data = new CatData();

        // dynamic data during the run
        public class Room
        {
            public Room(int coin, int hw) { coinToUnlock = coin;  hardWareToUnlock = hw; }

            public int coinToUnlock;
            public int hardWareToUnlock;
        };

        public int level = 0;
        public int numCats = 1; // number of cats we own
        List<Room> rooms = new List<Room>(); // rooms we've unlocked, so capacity = numRooms * 5
        List<float> toys = new List<float>(); //array of xp multipliers for the toys we own, keep this sorted
        int xp; // earned by playing with cats. Automatically levels you up and opens up new rooms 
        int coin; // money
        int hardware; // todo subdivide this later into screws, wood etc.

        // other useful stuff
        Random dice = new Random();

        // data arrays
        public int[] coinHistory;
        public int[] hardwareHistory;
        public int[] xpHistory;
        public int[] levelHistory;
        public int[] catsHistory;
        public int[] roomsHistory;

        // do the entire run
        public void Run()
        {
            coinHistory = new int[numSessions];
            hardwareHistory = new int[numSessions];
            xpHistory = new int[numSessions];
            levelHistory = new int[numSessions];
            catsHistory = new int[numSessions];
            roomsHistory = new int[numSessions];

            rooms.Add(new Room(0,0));

            StreamWriter file = new StreamWriter("Log.csv");
            file.WriteLine("Session,Level,Rooms,Cats,Coin,Hardware, XP");
            for (int i = 0; i < numSessions; i++)
            {
                RunSession();
                file.WriteLine("" + i +"," +  level + "," + GetNumRooms() + "," + numCats + "," + coin + "," + hardware + "," + xp);
                coinHistory[i] = coin;
                hardwareHistory[i] = hardware;
                xpHistory[i] = xp;
                levelHistory[i] = level;
                catsHistory[i] = numCats;
                roomsHistory[i] = GetNumRooms();
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
            xp += (int)(data.activeXP * multiplier);
            coin += (int)(data.activeCoin * multiplier);
        }

        // a single cat going for a neighbourhood wander
        void Wander()
        {
            //accumulate hardware
            hardware += data.wanderHardware;

            // might pick up a new cat if we have space
            if (dice.Next(0, 100) < data.pctNewCat && numCats < CatCapacity())
            {
                numCats++;
            }
        }

        // do what a good player would do with their coin and resources
        void SpendResources()
        {
            // automatic - have we levelled up?
            if (xp > data.GetXpForLevel(level))
            {
                level++;

                // automatic - have we unlocked a new room by levelling?
                if (level > data.GetNextRoomLevel(rooms.Count))
                {
                    Room r = new Room(
                        data.GetCoinForRoom(rooms.Count),
                        data.GetHardwareForRoom(rooms.Count));
                    rooms.Add(r);
                }
            }

            // automatic - subtract hardware to unlock new room
            for(int i =0;i < rooms.Count; i++)
            {
                Room r = rooms[i];
                if (r.coinToUnlock != 0 || r.hardWareToUnlock != 0)
                {
                    if (coin >= r.coinToUnlock && hardware >= r.hardWareToUnlock)
                    {
                        coin -= r.coinToUnlock;
                        hardware -= r.hardWareToUnlock;
                        r.coinToUnlock = 0;
                        r.hardWareToUnlock = 0;
                    }
                    break;
                }
            }
        }

        // HELPER FUNCTIONS
        int CatCapacity()
        {
            return GetNumRooms() * 5;
        }

        public int GetNumRooms()
        {
            int count = 0;
            foreach(Room r in rooms)
            {
                if (r.coinToUnlock == 0 && r.hardWareToUnlock == 0)
                    count++;
            }
            return count;
        }
    }
}
