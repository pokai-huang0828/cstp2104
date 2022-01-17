using Assignment2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Entities
{
    public class Vehicles
    {
        public VehicleTypes Type { get; set; }
        public int Year { get; set; }
        public EngineType Engine { get; set; }
        public FuelType Fuel { get; set; }
        public int MaxFuel { get; set;}
        public int ExistingFuel { get; set; }

        public Vehicles(int type, int year, int engine, int fuel, int maxfuel, int existingfuel  )
        {
            this.Type = (VehicleTypes)type;
            this.Year = year;
            this.Engine = (EngineType)engine;
            this.Fuel = (FuelType)fuel;
            this.MaxFuel = maxfuel;
            this.ExistingFuel = existingfuel;
        }
    }
}
