using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLot
{
    public class Level
    {
        private int floor;
        private ParkingSpot[] spots;
        private int availableSpots = 0;
        private int spotsPerRow = 10; //constant

        public Level()
        {

        }

        public int getAvailableSpots()
        {
            return availableSpots;
        }

        public void spotFreed()
        {
            availableSpots = availableSpots + 1;
        }

    }
}