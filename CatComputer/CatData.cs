using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatComputer
{
    // store all the fiddly settings in here for levlling up etc. 
    // use this in game too
    public class CatData
    {
        // xp accumulated per cat
        public int passiveXP = 10;
        public int activeXP = 100;
        public int passiveCoin = 10;
        public int activeCoin = 100;
        // how much hardware do you get from wandering
        public int wanderHardware = 5;
        // percentage of picking up a new cat from wandering
        public int pctNewCat = 10;

        // xp to level up
        int[] xpForLevel = { 10, 100, 200, 500, 1000, 2000, 5000, 10000 };
        public int GetXpForLevel(int level)
        {
            return xpForLevel[Math.Min(level, xpForLevel.Length - 1)];
        }

        struct Room
        {
            float costToReno;
            float hardwareToReno;
            int numCats;
        };
    
        int[] nextRoomLevel = { 0, 2, 5, 8, 14, 20, 30};
        int[] coinForRoom = { 0, 1000, 5000, 10000, 20000 };
        int[] hardwareForRoom = {0, 10, 50, 100, 200};

        public int GetNextRoomLevel(int numRooms)
        {
            int n = nextRoomLevel.Length;
            if (numRooms < n)
            {
                return nextRoomLevel[numRooms];
            }
            else
            {
                // linearly interpolate indefinitely
                return nextRoomLevel[n - 1] + (numRooms + 1 - n) * (nextRoomLevel[n - 1] - nextRoomLevel[n - 2]);
            }
        }

        public int GetCoinForRoom(int numRooms)
        {
            return coinForRoom[Math.Min(numRooms, coinForRoom.Length - 1)];
        }

        public int GetHardwareForRoom(int numRooms)
        {
            return hardwareForRoom[Math.Min(numRooms, hardwareForRoom.Length - 1)];
        }
    }
}
