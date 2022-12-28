using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Homework_8_method_2
{
    internal class MaqsudHostel : Hotel,IFoodService
    {
        public string Place { get; set; }
        public byte Star { get; set; }
        public double PriceForDay { get; set; }

        public void FoodService()
        {
            Console.WriteLine("We do not have food service");
        }
    }
}
