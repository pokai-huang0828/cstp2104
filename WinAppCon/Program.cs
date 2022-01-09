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
                
            };

            Car car2 = new Car()
            {
                Engine = Engines.Eletric,
                Make = "Merceds",
                Year = 2021,

            };

            Console.ReadLine();
        }
    }
}
