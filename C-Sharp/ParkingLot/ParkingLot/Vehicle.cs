using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLot
{

    public abstract class Vehicle
    {
        protected List<ParkingSpot> parkingSpots = new List<ParkingSpot>();
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

        public void parkInSpot(ParkingSpot spot)
        {
            parkingSpots.Add(spot);
        }

        // Will remove vehicle from spot
        public void clearSpots()
        {

        }

        public abstract bool canFitInSpot(ParkingSpot spot);
    }
}