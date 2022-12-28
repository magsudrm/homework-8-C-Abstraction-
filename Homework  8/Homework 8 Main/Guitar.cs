using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8_Main
{
    internal class Guitar : MusicalInstrument, IMusicalInstrument, IPlay
    {
        public int Price { get; set; }
        public string MeaningOfName { get; set; }
        public string PlayingStyle { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("E, A, D, G, B, E");
        }
    }
}
