using System;
using System.Collections.Generic;
using System.Text;

namespace WinAppLib.OOD.Jan15
{
    public class Squarer : ICalculator
    {
        public int Calculate(int x)
        {
            return x * x;
        }
    }
}
