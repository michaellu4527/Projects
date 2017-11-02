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
        int largeSpots;
        int compactSpots;
        int bikeSpots;
        int xlSpots;
        int row;

        // Initializing values for number of parking spots
        public Level(int numberOfSpots)
        {
            spots = new ParkingSpot[numberOfSpots];
            largeSpots = numberOfSpots / 4;
            compactSpots = numberOfSpots - largeSpots - bikeSpots - xlSpots;
            bikeSpots = numberOfSpots / 12;
            xlSpots = numberOfSpots / 12;

            for (int i = 0; i < numberOfSpots; i++)
            {
                VehicleSize sz = VehicleSize.Small;
                if (i < largeSpots)
                {
                    sz = VehicleSize.Large;
                }
                else if (i < largeSpots + compactSpots)
                {
                    sz = VehicleSize.Medium;
                }
                row = i / spotsPerRow;
                spots[i] = new ParkingSpot(this, row, i, sz);
                
            }
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