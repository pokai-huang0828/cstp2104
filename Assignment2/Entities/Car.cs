using Assignment2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class Car : Vehicles
    {
        public Car(int type, int year, int engine) : base(type, year, engine)
        {
        }
    }
}
