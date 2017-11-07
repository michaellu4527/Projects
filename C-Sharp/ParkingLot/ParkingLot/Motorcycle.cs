using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLot
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            spotsNeeded = 1;
        }

        public override bool canFitInSpot(ParkingSpot spot)
        {

            if (getSize() > 0)
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