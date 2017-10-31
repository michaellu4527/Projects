using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLot
{
    public class Bus : Vehicle
    {
        public Bus()
        {
            spotsNeeded = 5;
            size = 5;
        }

        public override bool canFitInSpot(ParkingSpot spot)
        {
         
            if (getSize() >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}