using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdekinin_tekrari
{
    internal abstract class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }
        public string Name;
        public byte Age;
        public abstract void MakeSound();
    }
}
