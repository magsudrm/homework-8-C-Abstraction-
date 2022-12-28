using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdekinin_tekrari
{
    internal class Dog:Animal
    {
        public Dog(string name) : base(name)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Hav");
        }
    }
}
