using Assignment2;
using Assignment2.Entities;
using Assignment2.Enum;
using Assignment2.Enum.Car_Enum;
using System;
using System.Collections.Generic;

namespace Assignment2Consle
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Store.AddCar(VehicleTypes.Car,
                     CarModels.SX4,
                     2021,
                     EngineType.Cylinder_6,
                     FuelType.Gasoline,
                     32.02,
                     false);
            Store.AddCar(VehicleTypes.Car, CarModels.Swift, 2020, EngineType.Cylinder_4, FuelType.Gasoline, 25.85, false);



            Console.WriteLine("CSTP2104--Assignment 2\n");
            Console.WriteLine("Welcome to Suzuki vehicles!! ");

            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine("\nYou chose " + action);

                switch (action)
                {
                    case 1:
                        Console.WriteLine("Let's veiw all vehicles!!\n");

                        Store.ShowAllCars();

                        
                        break;
                }
                action = chooseAction();
            }

            static int chooseAction()
            {
                int choice = 0;
                Console.WriteLine("Choose an action (0) to quit (1) to veiw all vehicle's details\n");

                choice = int.Parse(Console.ReadLine());
                return choice;
            }


        }
    }
}
