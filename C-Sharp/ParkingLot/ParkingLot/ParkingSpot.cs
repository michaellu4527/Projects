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


        // Will link ID number of parking spot to car
        public double getSpotID()
        {
            return spotID;
        }

        public double getSpotSize()
        {
            return spotSize;
        }

        public Vehicle findCar()
        {

        }

        // Will empty parking spot if vehicle leaves
        public void clearSpot()
        {

        }
    }
}