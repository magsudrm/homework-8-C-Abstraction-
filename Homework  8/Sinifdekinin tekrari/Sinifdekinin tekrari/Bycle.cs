using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdekinin_tekrari
{
    internal class Bycle:Vehicle
    {
        public override void Drive(int km)
        {
            Millage += km;
        }
    }
}
