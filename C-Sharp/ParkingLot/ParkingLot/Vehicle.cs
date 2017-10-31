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

        protected int getSize() {
            return size;
        }

        protected int getSpotsNeeded()
        {
            return spotsNeeded;
        }

    }
}