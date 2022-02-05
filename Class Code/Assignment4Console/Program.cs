using Assignment4;
using System;

namespace Assignment4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment4();
        }

        private static void Assignment4()
        {
            var adoNet = new AdoNet();
            adoNet.CreateTables();
        }
    }
}
