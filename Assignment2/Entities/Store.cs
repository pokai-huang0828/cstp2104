using Assignment2.Enum;
using Assignment2.Enum.Car_Enum;
using Assignment2.Enum.Motor_Enum;
using Assignment2.Enum.Truck_Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Entities
{
    public class Store
    {
        public static List<Car> CarList = new List<Car>();
        public static List<Motorcycle> MotorcycleList = new List<Motorcycle>();
        public static List<Truck> TruckList = new List<Truck>();
        
        public static void AddCar(VehicleTypes Type, CarModels CarModel, int Year, EngineType Engine, FuelType Fuel, double CurrentFuel, bool IsRepairNeeded)
        {
            CarList.Add(new Car((int)Type, (int)CarModel, Year, (int)Engine, (int)Fuel, CurrentFuel, IsRepairNeeded));
        }

        public static List<Car> GetCars()
        {
            return CarList;
        }

        public static void AddMotorcycle(VehicleTypes Type, MotorModels MotorModel, int Year, EngineType Engine, FuelType Fuel, double CurrentFuel, bool IsRepairNeeded)
        {
            MotorcycleList.Add(new Motorcycle((int)Type, (int)MotorModel, Year, (int)Engine, (int)Fuel, CurrentFuel, IsRepairNeeded));
        }

        public static List<Motorcycle> GetMotorcycles()
        {
            return MotorcycleList;
        }

        public static void AddTruck(VehicleTypes Type, TruckModel TruckModel, int Year, EngineType Engine, FuelType Fuel, double CurrentFuel, bool IsRepairNeeded)
        {
            TruckList.Add(new Truck((int)Type, (int)TruckModel, Year, (int)Engine, (int)Fuel, CurrentFuel, IsRepairNeeded));
        }

        public static List<Truck> GetTrucks()
        {
            return TruckList;
        }

        public static void ShowAllCars()
        {
            List<Car> ShowCars = GetCars();
            foreach(Car car in CarList)
            {
                Console.WriteLine(
                            "\nvehicletype: " + car.Type +
                            "\nmodel: " + car.CarModel +
                            "\nyear: " + car.Year +
                            "\nenginetype: " + car.Engine +
                            "\nfueltype: " + car.Fuel +
                            "\ncurrentfuel: " + car.CurrentFuel +
                            "\nestimate distance: " + car.EstimateDistance() +
                            "\nrepair needed: " + car.IsRepairNeeded
                            );
            }
        }
        
    }
}
