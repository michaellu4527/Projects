using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLot
{
    public class ParkingLot
    {
        
        private int zipCode;

        public void placeVehicle(ParkingSpot spot)
        {
            parkingSpots.Add(spot);
        }

        public void clearSpot()
        {
            for (int i = 0; i < parkingSpots.Count(); i++)
            {
                // Call removeVehicle
            }
        }
    }
}