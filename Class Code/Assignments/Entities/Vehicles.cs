using System;
using System.Collections.Generic;
using System.Text;
using Assignment.Enum;

namespace Assignment
{
    public class Vehicles
    {

        public VehicleTypes Type { get; set; }
        public int Year { get; set; } 
        public int Mileage { get; set; }
        public decimal Price { get; set; }

        public Vehicles(VehicleTypes type)
        {
            Type = VehicleTypes.Unknown;
            Year = 0000;
            Mileage = 0000;
            Price = 0000;
        }

        public Vehicles(int t, int y, int m, decimal p)
        {
            Type = (VehicleTypes)t;
            Year = y;
            Mileage = m;
            Price = p;
        }

        override public string ToString()
        {
            return "VehicleType: " + Type + "Year: " + Year + "Mileage: " + Mileage + " km" +"Price: $" + Price;
        }


    }
}
