using Assignment.Enum;
using Assignment.Enum.Truck_Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Entities
{
    public class Truck : Vehicles
    {
        public Truck(VehicleTypes type, TruckBrands brand, TruckModel model, EngineType engine, int year, int mileage, decimal price) : base(type, year, mileage, price)
        {
            Brand = brand;
            Models = model;
            Engine = engine;
        }

        public TruckBrands Brand { get; set; }
        public TruckModel Models { get; set; }
        public EngineType Engine { get; set; }
    }
}
