using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdekinin_tekrari
{
    internal class Car:Vehicle
    {
        public double CurrentFuel;
        public double FuelForKm;
        public override void Drive(int km)
        {
            if (CurrentFuel >= km * FuelForKm)
            {
                CurrentFuel -= km * FuelForKm;
                Millage += km;
            }
        }
    }
}
