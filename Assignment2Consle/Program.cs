using Assignment2;
using Assignment2.Entities;
using System;

namespace Assignment2Consle
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicles v1 = new Vehicles(1, 2021, 3);

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
                            "\nVehicleType: " + v1.Type +
                            "\nYear: " + v1.Year +
                            "\nEngineType: " + v1.Engine
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
