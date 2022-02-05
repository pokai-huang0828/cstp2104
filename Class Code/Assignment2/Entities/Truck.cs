using Assignment2.Entities;
using Assignment2.Enum.Truck_Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class Truck : Vehicles, FCalculator
    {
        public Truck(int Type, int TruckModel, int Year, int Engine, int Fuel, double CurrentFuel, bool IsRepairNeeded) : base(Type, Year, Engine, Fuel, CurrentFuel, IsRepairNeeded)
        {
            this.TruckModel = (TruckModel)TruckModel;
        }

        public TruckModel TruckModel { get; private set; }

        public double EstimateDistance()
        {
            return Math.Round(kmPerLiter * CurrentFuel, 3);
        }
    }
}
