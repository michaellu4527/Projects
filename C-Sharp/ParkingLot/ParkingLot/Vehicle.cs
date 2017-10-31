using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLot
{
    public enum VehicleSize { Motorcycle, Compact, Large }

    public abstract class Vehicle
    {
        protected List<ParkingSpot> parkingSpots = new List<ParkingSpot>();
        protected String licensePlate;
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

        // Will remove vehicle from spot
        public void clearSpots()
        {

        }

        // Will "park" a vehicle into a particular parking spot.
        public void parkInSpot(ParkingSpot s)
        {
            parkingSpots.Add(s);
        }

        public abstract Boolean canFitInSpot(ParkingSpot spot);
    }
}