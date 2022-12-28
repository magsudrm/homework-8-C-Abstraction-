using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar_Interface
{
    internal class Gun
    {
        public Gun(string country)
        {
            MakeCountry = country;
        }
        public string MakeCountry;

        public void ShowInfo()
        {
            Console.WriteLine($"{MakeCountry}");
        }
    }
}
