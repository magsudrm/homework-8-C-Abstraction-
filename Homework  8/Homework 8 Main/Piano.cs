using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8_Main
{
    internal class Piano:MusicalInstrument,IMusicalInstrument,IPlay
    {
        public int Price { get; set; }
        public string MeaningOfName { get; set; }
        public string PlayingStyle { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("C, C-Sharp (D-Flat), D, D-sharp (E-Flat), E, F, F-Sharp (G-Flat), G,  B. ");
        }
    }
}
