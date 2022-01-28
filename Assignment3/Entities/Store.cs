using Assignment3.Enum;
using Assignment3.Enum.Car_Enum;
using Assignment3.Enum.Motor_Enum;
using Assignment3.Enum.Truck_Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3.Entities
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
            CarList.AsParallel().ForAll(car => Console.WriteLine(
                $"\n1. Vehicletype:{ car.Type } " +
                $"\n2. Model:{ car.CarModel } " +
                $"\n3. Year:{ car.Year } " +
                $"\n4. Enginetype:{ car.Engine } " +
                $"\n5. Currentfuel:{ car.Fuel } " +
                $"\n6. Model:{ car.CurrentFuel } litre" +
                $"\n7. Estimate distance:{ car.EstimateDistance() } km" +
                $"\n8. Require { car.FuelNeedForDistanceCalculator(450) } litre's fuel for travelling 450km."));
        }

        public static void ShowAllMotorcycles()
        {
            GetMotorcycles();
            MotorcycleList.AsParallel().ForAll(motorcycle => Console.WriteLine(
                $"\n1. Vehicletype:{ motorcycle.Type } " +
                $"\n2. Model:{ motorcycle.MotorModel } " +
                $"\n3. Year:{ motorcycle.Year } " +
                $"\n4. Enginetype:{ motorcycle.Engine } " +
                $"\n5. Currentfuel:{ motorcycle.Fuel } " +
                $"\n6. Model:{ motorcycle.CurrentFuel } litre" +
                $"\n7. Estimate distance:{ motorcycle.EstimateDistance() } km" +
                $"\n8. Require { motorcycle.FuelNeedForDistanceCalculator(450) } litre's fuel for travelling 450km."));
        }

        public static void ShowAllTrucks()
        {
            GetTrucks();
            TruckList.AsParallel().ForAll(truck => Console.WriteLine(
                $"\n1. Vehicletype:{ truck.Type } " +
                $"\n2. Model:{ truck.TruckModel } " +
                $"\n3. Year:{ truck.Year } " +
                $"\n4. Enginetype:{ truck.Engine } " +
                $"\n5. Currentfuel:{ truck.Fuel } " +
                $"\n6. Model:{ truck.CurrentFuel } litre" +
                $"\n7. Estimate distance:{ truck.EstimateDistance() } km" +
                $"\n8. Require { truck.FuelNeedForDistanceCalculator(450) } litre's fuel for travelling 450km."));
        }        
    }
}
