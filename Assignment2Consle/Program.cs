using Assignment2;
using Assignment2.Entities;
using System;

namespace Assignment2Consle
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicles v1 = new Vehicles(1, 2021, 1, 1, 100.0, false);
            Car c1 = new Car(1, 0, 2015, 1, 1, 45.2, false);

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

                        Console.WriteLine(
                            "\nVehicleType: " + c1.Type +
                            "\nModel: " + c1.CarModel +
                            "\nYear: " + c1.Year +
                            "\nEngineType: " + c1.Engine +
                            "\nFuelType: " + c1.Fuel +
                            "\nCurrentFuel: " + c1.CurrentFuel +
                            "\nEstimate Distance: " + c1.EstimateDistance() +
                            "\nRepair Needed: " + c1.IsRepairNeeded
                            );
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
