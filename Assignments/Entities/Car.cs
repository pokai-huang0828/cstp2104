using Assignment.Enum;
using Assignment.Enum.Car_Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Entities
{
    public class Car : Vehicles
    {
       
        public Car(VehicleTypes type, CarBrands brand, CarModels model, EngineType engine, int year, int mileage, decimal price) : base(type, year, mileage, price)
        {
            Brand = brand;
            Models = model; 
            Engine = engine;
        }

        public CarBrands Brand { get; set; }
        public CarModels Models { get; set; }
        public EngineType Engine { get; set; }
    }
}
