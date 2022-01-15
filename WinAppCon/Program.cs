using System;
using WinAppLib.OOD;
using WinAppLib.OOD.Jan15;

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

            Program.Display1(car);
            Program.Display1(car2);

            Vehicle v = car; // Upcast
            Car car3 = (Car)v; // Downcast

            var truck = new Truck();
            Vehicle vt = truck;
            Car car4 = (Car)vt; // Run-time error InvalidCastException

            Console.WriteLine(" ");

            // -------------- Jan 15th 2022-------------------

            // as operator
            // is operator

            var values = new int[] { 2, 4, 5, 8 };
            var result = Program.Calculate(values, new Squarer());
            Program.Display(result);

            result = Program.Calculate(values, new Cuber());
            Program.Display(result);

            result = Program.Calculate(values, new CustomCalculator());
            Program.Display(result);

            Console.WriteLine("\n");

            string s = "123";
            var isCapitalized = s.IsCapitalized();
            Console.WriteLine($"{s} IsCapitalized:{isCapitalized}");

            s = "Ace";
            isCapitalized = s.IsCapitalized();
            Console.WriteLine($"{s} IsCapitalized:{isCapitalized}");

            s = "base";
            isCapitalized = s.IsCapitalized();
            Console.WriteLine($"{s} IsCapitalized:{isCapitalized}");
            
            s = " ";
            isCapitalized = s.IsCapitalized();
            Console.WriteLine($"{s} IsCapitalized:{isCapitalized}");
            

        }


        public static int[] Calculate(int[] values, ICalculator calculator)
        {
            int[] result = new int[values.Length];
            for(int i = 0; i < values.Length; i++)
            {
                var r = calculator.Calculate(values[i]);
                result[i] = r;
            }
            return result;
        }

        public static void Display(int[] values)
        {
            for(int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"i = {i} {values[i]}");
            }
        }

        // --------------------------------------------------------

        public static void Display1(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.Model);
            Console.WriteLine(vehicle.makes);
            Console.WriteLine(vehicle.Year);
        }

        public static void Display2(Truck truck)
        {

        }
    }

    // -------------- Jan 15th 2022 -----------------------

    public static class StringHelper
    {
        // Extension method
        public static bool IsCapitalized(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            return char.IsUpper(s[0]);
        }
    }

    // ---------------------------------------------------
}
