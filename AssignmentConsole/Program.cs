using Assignment;
using Assignment.Entities;
using Assignment.Enum;
using Assignment.Enum.Car_Enum;
using Assignment.Enum.Motor_Enum;
using Assignment.Enum.Truck_Enum;
using System;

namespace AssignmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Car Car1 = new Car(VehicleTypes.Car, CarBrands.Audi, CarModels.CModel_1, EngineType.Eletric ,2000, 320, 9000);

            Truck Truck1 = new Truck(VehicleTypes.Truck, TruckBrands.GMC, TruckModel.TModel_5, EngineType.Cylinder_12, 2010, 2452, 12000);

            Motorcycle Motor1 = new Motorcycle(VehicleTypes.Motorcycle, MotorBrands.BMW, MotorModel.MotorModel_3, EngineType.Cylinder_4, 2021, 1587, 5000);


            Console.WriteLine("CSTP2104--Assignment 1\n");
            Console.WriteLine("Welcome to PoKai Vehicle Store!");

            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine("\nYou chose " + action);

                switch (action)
                {
                    case 1:

                        Console.WriteLine("Let's veiw all vehicles!!\n");

                        Console.WriteLine(
                            "\nVehicleType: " + Car1.Type +
                            "\nBrand: " + Car1.Brand +
                            "\nModel: " + Car1.Models +
                            "\nEngine: " + Car1.Engine +
                            "\nYear: " + Car1.Year + 
                            "\nMileage: " + Car1.Mileage + " km" + 
                            "\nPrice: $" + Car1.Price + "\n"
                            );

                        Console.WriteLine(
                            "\nVehicleType: " + Truck1.Type +
                            "\nBrand: " + Truck1.Brand +
                            "\nModel: " + Truck1.Models +
                            "\nEngine: " + Truck1.Engine +
                            "\nYear: " + Truck1.Year +
                            "\nMileage: " + Truck1.Mileage + " km" +
                            "\nPrice: $" + Truck1.Price + "\n"
                            );

                        Console.WriteLine(
                            "\nVehicleType: " + Motor1.Type +
                            "\nBrand: " + Motor1.Brand +
                            "\nModel: " + Motor1.Models +
                            "\nEngine: " + Motor1.Engine +
                            "\nYear: " + Motor1.Year +
                            "\nMileage: " + Motor1.Mileage + " km" +
                            "\nPrice: $" + Motor1.Price + "\n"
                            );

                        break;
                }

                action = chooseAction();        
            }

            static int chooseAction()
            {
                int choice = 0;
                Console.WriteLine("Choose an action (0) to quit (1) to veiw all vehicles\n");

                choice = int.Parse(Console.ReadLine());
                return choice;
            }

            

        }
    }
}
