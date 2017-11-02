using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLot
{
    public class ParkingSpot
    {
        private double spotID;
        private enum VehicleSize { ExtraLarge, Large, Medium, Small }
        private int spotSize;
        private int row;
        private Level level;


        // Will link ID number of parking spot to car
        public double getSpotID()
        {
            return spotID;
        }

        public double getSpotSize()
        {
            return spotSize;
        }

        // Parks Vehicle
        public bool parkVehicle(Vehicle v)
        {
            if (v.canFitInSpot(this))
            {
                v.parkInSpot(this);
                return true;
            }
        }

        // Removes vehicle from parking spot
        public bool removeVehicle(Vehicle v)
        {

        }

        // Will empty parking spot if vehicle leaves
        public void clearSpot()
        {

        }
    }
}