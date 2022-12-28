using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8_method_2
{
    internal class Rixos:Hotel,IFoodService
    {
        public string Place { get; set; }
        public byte Star { get; set; }
        public double PriceForDay { get; set; }

        public void FoodService()
        {
            Console.WriteLine("It is advisable to eat at our open buffet");
        }
    }
}
