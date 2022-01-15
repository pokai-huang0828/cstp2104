using System;
using System.Collections.Generic;
using System.Text;

namespace WinAppLib.OOD
{
    public interface ICalculator
    {
        int Calculator(int x)
        {
            return (x * x * x);
        }

    }
}
