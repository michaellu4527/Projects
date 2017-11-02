using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLot
{
    public class ParkingSpot
    {
        private Vehicle vehicle;
        private double spotID;
        private int spotSize;
        private int row;
        private Level level;

        public ParkingSpot(Level lvl, int rw, int num, VehicleSize sz)
        {
            level = lvl;
            row = rw;
            spotID = num;
            spotSize = (int)sz;           
        }

        public bool isAvailable()
        {
            if (this == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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
            else
            {
                return false;
            }
        }

        // Removes vehicle from parking spot
        public void removeVehicle() 
        {

        }

        // Will empty parking spot if vehicle leaves
        public void clearSpot()
        {

        }
    }
}