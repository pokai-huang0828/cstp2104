using System;
using System.Collections.Generic;
using System.Text;

namespace WinAppLib.OOD
{
    public class Car: Vehicle
    {
        public string Trim;
        public string BodyType;

        public decimal Kilometers;
        public decimal Price;

        public Car()
        {
            Engine = Engines.Eletric;
        }

        public Car(string model)
        {
            this.Model = model;
        }

        public string Make { get; set; }
    }
}
