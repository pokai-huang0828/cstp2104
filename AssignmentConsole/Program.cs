using Assignment;
using Assignment.Entities;
using Assignment.Enum;
using Assignment.Enum.Car_Enum;
using System;

namespace AssignmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment1\n");
            Console.WriteLine();
            Console.WriteLine("  Welcome to PoKai Vehicle Store!");

            int action = chooseAction();
            Console.WriteLine();

            while (action != 0)
            {
                Console.WriteLine(" You chose " + action);
                action = chooseAction();        
            }

            static int chooseAction()
            {
                int choice = 0;
                Console.WriteLine(" Choose an action (0) to quit (1) to add a new vehicle\n");

                choice = int.Parse(Console.ReadLine());
                return choice;
            }          

        }
    }
}
