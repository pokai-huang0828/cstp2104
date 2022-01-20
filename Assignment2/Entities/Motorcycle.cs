using Assignment2.Entities;
using Assignment2.Enum.Motor_Enum;
using System;

namespace Assignment2
{
    public class Motorcycle : Vehicles, FCalculator
    {
        public Motorcycle(int Type, int MotorModel, int Year, int Engine, int Fuel, double CurrentFuel, bool IsRepairNeeded) : base(Type, Year, Engine, Fuel, CurrentFuel, IsRepairNeeded)
        {
            this.MotorModel = (MotorModels)MotorModel;
        }

        public MotorModels MotorModel { get; private set; }

        public double EstimateDistance()
        {
            return Math.Round(kmPerLiter * CurrentFuel, 3);
        }
    }
}
