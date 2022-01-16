using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Entities
{
    public class Vehicles
    {
        public VehicleTypes Type { get; set; }
        public int Year { get; set; }

        public Vehicles(int t, int y)
        {
            this.Type = (VehicleTypes)t;
            this.Year = y;
        }
    }
}
