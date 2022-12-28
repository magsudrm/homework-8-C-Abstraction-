using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8_method_2
{
    internal class FourSeason : Hotel,IFoodService
    {
        public string Place { get; set; }
        public byte Star { get; set; }
        public double PriceForDay { get; set; }

        public void FoodService()
        {
            Console.WriteLine("It is recommended that you eat at our restaurant");
        }
    }
}
