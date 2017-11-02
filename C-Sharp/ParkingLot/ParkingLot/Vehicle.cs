using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLot
{
    public enum VehicleSize { ExtraLarge, Large, Medium, Small };

    public abstract class Vehicle
    {
        protected String licensePlate;
        protected enum color { Red, Blue, Silver, Black };
        protected int spotsNeeded;
        protected int size;

        // Returns the size of the vehicle
        protected int getSize() {
            return size;
        }

        // Will just retreive the number of spots needed to park vehicle.
        protected int getSpotsNeeded()
        {
            return spotsNeeded;
        }

        // Simulates parking a vehicle in a particular parking spot
        public void parkInSpot(ParkingSpot spot)
        {
            parkingSpots.Add(spot);
        }

        // Simulates removing a vehicle from a parking spot
        public void clearSpots()
        {
            for (int i = 0; i < parkingSpots.Count; i++)
            {
                
            }
            parkingSpots.Clear();
        }

        public abstract bool canFitInSpot(ParkingSpot spot);
    }
}