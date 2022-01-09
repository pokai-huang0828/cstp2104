using System;
using System.Collections.Generic;
using System.Text;
using Assignment.Enum;

namespace Assignment
{
    public class Vehicles
    {
        public Vehicles(VehicleTypes type, int year, int mileage, decimal price)
        {
            Type = type;
            Year = year;
            Mileage = mileage;
            Price = price;
        }

        public VehicleTypes Type { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public decimal Price { get; set; }
    }
}
