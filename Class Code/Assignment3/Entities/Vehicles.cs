using Assignment3.Enum;

namespace Assignment3.Entities
{
    public class Vehicles
    {
        public VehicleTypes Type { get; set; }
        public int Year { get; set; }
        public bool IsRepairNeeded { get; }
        public EngineType Engine { get; set; }
        public FuelType Fuel { get; set; }
        public double CurrentFuel { get; private set; }
        public double kmPerLiter;
        public double FuelNeedForDistance;

        public Vehicles(int Type, int Year, int Engine, int Fuel, double CurrentFuel, bool IsRepairNeeded)
        {
            this.Type = (VehicleTypes)Type;
            this.Year = Year;
            this.IsRepairNeeded = IsRepairNeeded;
            this.Engine = (EngineType)Engine;
            this.Fuel = (FuelType)Fuel;
            this.CurrentFuel = CurrentFuel;

            if (Engine == 0) // Unknown
            {
                kmPerLiter = 0;
            }
            else if (Engine == 1) // Cylinder_2
            {
                kmPerLiter = 12.9;
            }
            else if (Engine == 2) // Cylinder_4
            {
                kmPerLiter = 10.7;
            }
            else if (Engine == 3) // Cylinder_6
            {
                kmPerLiter = 9.2;
            }
            else if (Engine == 4) // Cylinder_8
            {
                kmPerLiter = 7.8;
            }
            else if (Engine == 5) // Cylinder_10
            {
                kmPerLiter = 5.4;
            }
            else if (Engine == 6) // Cylinder_12
            {
                kmPerLiter = 3.9;
            }
            else if (Engine == 7) // Eletric
            {
                kmPerLiter = 10.7;
            }
        }
    }
}
