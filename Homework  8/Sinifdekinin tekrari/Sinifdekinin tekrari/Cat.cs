using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdekinin_tekrari
{
    internal class Cat:Animal
    {
        public Cat(string name) : base(name)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
