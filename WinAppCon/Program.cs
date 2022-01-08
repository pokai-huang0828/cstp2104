using System;

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

            Console.ReadLine();
        }
    }
}
