using System;
using WinAppLib.OOD;

namespace WinAppCon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Windows Application Development !");
            Console.BackgroundColor = ConsoleColor.Black;

            Car car = new Car()
            {
                Engine = Engines.Cylinder_4,
                Make = "Mercedes",
                Year = 2021,
                Model = "X3",
       
            };

            Car car2 = new Car()
            {
                Engine = Engines.Eletric,
                Make = "Merceds",
                Year = 2021,
                Model = "Corola",
            };

            Program.Display(car);
            Program.Display(car2);

            Vehicle v = car; // Upcast
            Car car3 = (Car)v; // Downcast

            var truck = new Truck();
            Vehicle vt = truck;
            Car car4 = (Car)vt; // Run-time error InvalidCastException

            // as operator
            // is operator
        }

        public static void Display(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.Model);
            Console.WriteLine(vehicle.Make);
            Console.WriteLine(vehicle.Year);
        }

        public static void Display2(Truck truck)
        {

        }
    }
}
