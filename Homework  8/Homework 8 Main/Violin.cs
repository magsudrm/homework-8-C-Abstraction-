using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8_Main
{
    internal class Violin : MusicalInstrument, IMusicalInstrument,IPlay
    {
        public int Price { get ; set  ; }
        public string MeaningOfName { get ; set ; }
        public string PlayingStyle { get; set; }

        public void MakeSound()
        {
            Console.WriteLine(" A, A#, B, C, C#, D, D#, E, F, F#, G, G#.");
        }
    }
}
