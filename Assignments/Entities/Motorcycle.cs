using Assignment.Enum;
using Assignment.Enum.Motor_Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Entities
{
    public class Motorcycle : Vehicles
    {
        public Motorcycle(VehicleTypes type, MotorBrands brand, MotorModel model, EngineType engine, int year, int mileage, decimal price) : base(type, year, mileage, price)
        {
            Brand = brand;
            Models = model;
            Engine = engine;
        }

        public MotorBrands Brand { get; set; }
        public MotorModel Models { get; set; }
        public EngineType Engine { get; set; }
    }
}
