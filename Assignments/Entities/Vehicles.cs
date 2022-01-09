using System;
using System.Collections.Generic;
using System.Text;
using Assignment.Enum;

namespace Assignment
{
    public class Vehicles
    {
        public Vehicles(VehicleTypes type, string brand, string model, int year, int mileage, decimal price)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            Price = price;
        }

        public VehicleTypes Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public decimal Price { get; set; }
    }
}
