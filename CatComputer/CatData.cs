using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


// THE STORY WE WANT
// level up quickly to level 3 in the first play session
// Session 14 (1 week play) : 2 rooms full of cats
// Session 28 (2 weeks play) :
// Session 250 (~4 months play) : 25 rooms full of cats
namespace CatComputer
{
    // store all the fiddly settings in here for levlling up etc. 
    // use this in game too
    public class CatData
    {
        // xp accumulated per cat from just being there and from playing
        public int passiveXP = 50;
        public int activeXP = 200;
        public int passiveCoin = 50;
        public int activeCoin = 1000;

        // percentage of picking up a new cat from wandering
        public int pctNewCat = 10;

        // chance of getting coin/hardware from a wander, and the rewards
        public int pctWanderCoin = 10;
        public int wanderCoin = 1000;
        public int pctWanderHardware = 10;
        public int wanderHardware = 8;

        // xp to level up (Kimbos HayDay data)
        int[] xpForLevel = {
27,
12,
20,
30,
50,
220,
370,
490,
790,
960,
1180,
1550,
1790,
2270,
2880,
3170,
4120,
4740,
5410,
6120,
7750,
9140,
10630,
12200,
13700,
15400,
17900,
20100,
23400,
26100,
27800,
27900,
26100,
28200,
29000,
29200,
29800,
30300,
30800,
31300,
31800,
32300,
32800,
31200,
31300,
32000,
36000,
37200,
40200,
41800,
42000,
42200,
41000,
38000,
42000,
42100,
42600,
44800,
43000,
45000,
48200,
49300,
50400,
51500,
54200,
52000,
55300,
55200,
60200,
62200,
66000,
68000,
72000,
70000,
74100,
76900,
80100,
80000,
85000,
        };

        // the best toy multiplier available at each level
        public float GetToyMultForLevel(int level)
        {
            return 1.1f + 0.05f * (level / 5);
        }

        // the cost of a toy with a given rank
        public int GetToyCost(float mult)
        {
            int rank = (int)(10.0f * (mult - 1.0f));
            return rank * rank * 1000;
        }

        public int GetXpForLevel(int level)
        {
            int total = 0;
            for(int i=0;i< level; i++)
                total += xpForLevel[Math.Min(level, xpForLevel.Length - 1)];
            return total;
        }

        public struct Room
        {
            public int unlockLevel;
            public int coinToReno;
            public int hardwareToReno;
            public int numCats;
            public bool unlocked;
            public bool useable;

            public Room(int l, int c, int h1, int h2, int n)
            {
                unlockLevel = l;
                coinToReno = c;
                hardwareToReno = h1 + h2;
                numCats = n;
                unlocked = false;
                useable = false;
            }

        };

        public Room[] rooms = {
//new Room( 0, 0       ,0      ,0  ,5  ),
//new Room( 1, 12000   ,30     ,4  ,5  ),
//new Room( 3, 45000   ,15     ,1  ,7  ),
//new Room( 6, 20000   ,70     ,6  ,5  ),
//new Room( 8, 100000  ,160    ,5  ,8  ),
//new Room(11, 60000   ,100    ,10 ,5  ),
//new Room(14, 90000   ,115    ,4  ,7  ),
//new Room(15, 75000   ,250    ,6  ,5  ),
//new Room(18, 85000   ,90     ,3  ,6  ),
//new Room(21, 68000   ,250    ,5  ,5  ),
//new Room(24, 125000  ,200    ,12 ,8  ),
//new Room(27, 85000   ,160    ,10 ,7  ),
//new Room(32, 62000   ,195    ,20 ,6  ),
//new Room(36, 35000   ,280    ,15 ,5  ),
//new Room(40, 42000   ,280    ,8  ,5  ),
//new Room(45, 120000  ,240    ,15 ,7  ),
//new Room(49, 38000   ,355    ,15 ,5  ),
//new Room(54, 97000   ,255    ,20 ,7  ),
//new Room(58, 45000   ,250    ,20 ,5  ),
//new Room(62, 54000   ,120    ,21 ,5  ),
//new Room(66, 26000   ,320    ,15 ,5  ),
//new Room(70, 106000  ,420    ,15 ,8  ),
//new Room(74, 53000   ,325    ,20 ,6  ),
//new Room(78, 86000   ,600    ,20 ,7  ),
//new Room(82, 140000  ,420    ,30 ,8  ),
};

        public void LoadRooms()
        {
            List<Room> newRooms = new List<Room>();

            StreamReader file = new StreamReader("../../Rooms.txt");
            
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] parts = line.Split(',');
                newRooms.Add(new Room(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4])));
            }
            file.Close();

            rooms = new Room[newRooms.Count];
            for (int i = 0; i < rooms.Length; i++)
                rooms[i] = newRooms[i];
        }

        int[] nextRoomLevel = { 0, 2, 5, 8, 14, 20, 30};
        int[] coinForRoom = { 0, 1000, 5000, 10000, 20000 };
        int[] hardwareForRoom = {0, 10, 50, 100, 200};

       
    }
}

