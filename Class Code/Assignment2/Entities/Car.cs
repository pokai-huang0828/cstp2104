using Assignment2.Entities;
using Assignment2.Enum.Car_Enum;
using System;

namespace Assignment2
{
    public class Car : Vehicles, FCalculator
    {
        public Car(int Type, int CarModel, int Year, int Engine, int Fuel, double CurrentFuel, bool IsRepairNeeded) : base(Type, Year, Engine, Fuel, CurrentFuel, IsRepairNeeded)
        {
            this.CarModel = (CarModels)CarModel;
        }

        public CarModels CarModel { get; private set; }

        public double EstimateDistance()
        {
            return Math.Round(kmPerLiter * CurrentFuel, 2);
        }
    }
}
