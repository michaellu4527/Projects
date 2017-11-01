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
            // A bus will fit in any spot that is size 5 or larger
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