using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WinAppLib.OOD.MutiThread_Jan22
{
    public class ThreadExample
    {
        public void RunAThread()
        {
            Thread t = new Thread(DoCalculation);
            t.Start();
        }

        private void DoCalculation()
        {
            for (int i = 1; i < 10; i++)
            {
                var result = i * i;
                Console.WriteLine($"i={i}, result= {result}");
            }
        }
    }
}
