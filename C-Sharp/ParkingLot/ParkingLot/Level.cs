﻿using System;
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

        // Simply returns the number of available spots.
        public int getAvailableSpots()
        {
            return availableSpots;
        }

        // Finds out whether or not a vehicle can be parked or not
        public bool canParkVehicle(Vehicle vehicle)
        {
            if (getAvailableSpots() < vehicle.getSpotsNeeded())
            {
                return false;
            }
            int spotID = findAvailableSpots(vehicle);
            if (spotID < 0)
            {
                return false;
            }
            return parkStartingAtSpot(spotID, vehicle);
        }

        private bool parkStartingAtSpot(int spotID, Vehicle vehicle)
        {
            vehicle.clearSpots();
            bool success = true;
            // Parks a vehicle starting from the spot ID and stopping at vehicle.spotsNeeded
            for (int i = spotID; i < spotID + vehicle.getSpotsNeeded(); i++)
            {
                success &= spots[i].parkVehicle(vehicle);
            }
            availableSpots -= vehicle.getSpotsNeeded(); // Reduce available spots
            return success;
        }

        public void spotFreed()
        {
            availableSpots = availableSpots + 1;
        }

    }
}