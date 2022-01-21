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
            GetCars();
            foreach(Car car in CarList)
            {
                Console.WriteLine(
                            "\nVehicletype: " + car.Type +
                            "\nModel: " + car.CarModel +
                            "\nYear: " + car.Year +
                            "\nEnginetype: " + car.Engine +
                            "\nFueltype: " + car.Fuel +
                            "\nCurrentfuel: " + car.CurrentFuel + " liter" +
                            "\nEstimate distance: " + car.EstimateDistance() + " km" +
                            "\nRepair needed: " + car.IsRepairNeeded
                            );
            }
        }

        public static void ShowAllMotorcycles()
        {
            GetMotorcycles();
            foreach(Motorcycle motorcycle in MotorcycleList)
            {
                Console.WriteLine(
                            "\nVehicletype: " + motorcycle.Type +
                            "\nModel: " + motorcycle.MotorModel +
                            "\nYear: " + motorcycle.Year +
                            "\nEnginetype: " + motorcycle.Engine +
                            "\nFueltype: " + motorcycle.Fuel +
                            "\nCurrentfuel: " + motorcycle.CurrentFuel + " liter" +
                            "\nEstimate distance: " + motorcycle.EstimateDistance() + " km" +
                            "\nRepair needed: " + motorcycle.IsRepairNeeded
                            );
            }
        }

        public static void ShowAllTrucks()
        {
            GetTrucks();
            foreach(Truck truck in TruckList)
            {
                Console.WriteLine(
                            "\nVehicletype: " + truck.Type +
                            "\nModel: " + truck.TruckModel +
                            "\nYear: " + truck.Year +
                            "\nEnginetype: " + truck.Engine +
                            "\nFueltype: " + truck.Fuel +
                            "\nCurrentfuel: " + truck.CurrentFuel + " liter" +
                            "\nEstimate distance: " + truck.EstimateDistance() + " km" +
                            "\nRepair needed: " + truck.IsRepairNeeded
                            );
            }
        }        
    }
}
