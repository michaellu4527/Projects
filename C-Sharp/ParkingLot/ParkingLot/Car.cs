using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLot
{
    public class Car : Vehicle
    {
        public Car()
        {
            spotsNeeded = 1;
      
        }

        public override Boolean canFitInSpot(ParkingSpot spot)
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