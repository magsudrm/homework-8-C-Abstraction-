using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar_Interface
{
    internal interface IGun
    {
        int CurrentMagazine { get; set; }
        int MagazineCapacity { get; set; }
    }
}
