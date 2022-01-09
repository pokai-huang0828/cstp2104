using Assignment.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Entities
{
    public class Truck : Vehicles
    {
        public Truck(VehicleTypes type, string brand, string model, EngineType engine, int year, int mileage, decimal price) : base(type, brand, model, year, mileage, price)
        {
            Engine = engine;
        }

        public EngineType Engine { get; set; }
    }
}
