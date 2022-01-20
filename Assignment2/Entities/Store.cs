using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Entities
{
    public class Store
    {
        public List<Car> CarList { get; set; }
        public List<Motorcycle> MotorcycleList { get; set; }
        public List<Truck> TruckList { get; set; }

        public Store()
        {
            CarList = new List<Car>();
            MotorcycleList = new List<Motorcycle>();
            TruckList = new List<Truck>();
        }


    }
}
