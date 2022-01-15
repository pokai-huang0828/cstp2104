using System;
using System.Collections.Generic;
using System.Text;

namespace WinAppLib.OOD.Jan15
{
    public class Cuber : ICalculator
    {
        public int Calculate(int x)
        {
            return x * x * x;
        }
    }
}
