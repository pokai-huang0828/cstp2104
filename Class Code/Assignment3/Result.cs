using System;
using Assignment3.Entities;
using Assignment3.Enum;
using Assignment3.Enum.Car_Enum;
using Assignment3.Enum.Motor_Enum;
using Assignment3.Enum.Truck_Enum;
using System.Threading;

namespace Assignment3
{
    public class Result
    {
        public static void AddVehicles()
        {
            Store.AddCar(VehicleTypes.Car, CarModels.SX4, 2021, EngineType.Cylinder_6, FuelType.Gasoline, 32.02, false);
            Store.AddCar(VehicleTypes.Car, CarModels.Swift, 2020, EngineType.Cylinder_4, FuelType.Gasoline, 25.85, true);
            Store.AddCar(VehicleTypes.Car, CarModels.Jimmy, 2022, EngineType.Cylinder_6, FuelType.Diesel_Fuel, 55.85, false);

            Store.AddMotorcycle(VehicleTypes.Motorcycle, MotorModels.BURGMAN200, 2020, EngineType.Cylinder_2, FuelType.Gasoline, 5.5, false);
            Store.AddMotorcycle(VehicleTypes.Motorcycle, MotorModels.GSX_R1000R, 2021, EngineType.Cylinder_4, FuelType.Gasoline, 9.2, true);
            Store.AddMotorcycle(VehicleTypes.Motorcycle, MotorModels.Gixxer250, 2021, EngineType.Cylinder_4, FuelType.Gasoline, 8.1, false);

            Store.AddTruck(VehicleTypes.Truck, TruckModel.Carry_Truck, 2018, EngineType.Cylinder_8, FuelType.Diesel_Fuel, 53.21, false);
            Store.AddTruck(VehicleTypes.Truck, TruckModel.Carry_Mini, 2015, EngineType.Cylinder_6, FuelType.Diesel_Fuel, 47.3, false);
            Store.AddTruck(VehicleTypes.Truck, TruckModel.Carry_Kilo, 2018, EngineType.Cylinder_10, FuelType.Diesel_Fuel, 32.4, false);
        }

        public static void ShowResult() 
        { 

            Console.WriteLine("CSTP2104--Assignment 3\n");
            Console.WriteLine("Welcome to Suzuki Vehicles :) ");

            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine("\nYou chose " + action);

                switch (action)
                {
                    case 1:
                        Console.WriteLine("\n======= Car List ======");
                        Store.ShowAllCars();
                        Console.WriteLine("\n======= End =======");
                        break;

                    case 2:
                        Console.WriteLine("\n======= Motorcycle List ======");
                        Store.ShowAllMotorcycles();
                        Console.WriteLine("\n======= End =======");
                        break;

                    case 3:
                        Console.WriteLine("\n======= Truck List ======");
                        Store.ShowAllTrucks();
                        Console.WriteLine("\n======= End =======");
                        break;
                }
                action = chooseAction();
            }

            static int chooseAction()
            {
                int choice = 0;
                Console.WriteLine(
                    "\nChoose an action (0) to quit \n" +
                    "Choose (1) to veiw all Car's details\n" +
                    "Choose (2) to view all Motorcycle's details\n" +
                    "Choose (3) to view all Truck's details.\n");

                choice = int.Parse(Console.ReadLine());
                return choice;
            }
        }


    }
}
