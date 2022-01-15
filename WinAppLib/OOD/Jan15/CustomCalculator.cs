using System;
using System.Collections.Generic;
using System.Text;

namespace WinAppLib.OOD.Jan15
{
    public class CustomCalculator : ICalculator
    {
        public int Calculate(int x)
        {
            return ((x * x) + 8) / 2;
        }
    }
}
