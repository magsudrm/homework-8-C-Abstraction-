using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8_Main
{
    internal interface IMusicalInstrument
    {
        int Price { get; set; }
        string MeaningOfName { get; set; }
        string PlayingStyle { get; set; }
    }
}
