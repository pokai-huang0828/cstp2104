using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Entities
{
    public class Vehicles
    {
        public VehicleTypes Type { get; set; }
        public int Year { get; set; }

        public Vehicles(int type, int year)
        {
            this.Type = (VehicleTypes)type;
            this.Year = year;
        }
    }
}
