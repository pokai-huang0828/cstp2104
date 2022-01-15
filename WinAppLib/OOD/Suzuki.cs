using System;
using System.Collections.Generic;
using System.Text;

namespace WinAppLib.OOD
{
    public class Suzuki: Motorcycle
    {
        public override int GetMaxSpeed()
        {
            if (this.Engine == Engines.Cylinder_4)
            {
                return 240;
            }

            return 180;
        }
    }
}
