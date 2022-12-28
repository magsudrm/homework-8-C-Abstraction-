using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar_Interface
{
    internal class M4: Gun,IGun,IFireable
    {
        public M4(string makeCountry) : base(makeCountry)
        {
        }
        public int CurrentMagazine { get; set; }
        public int MagazineCapacity { get; set; }
        public void Fire()
        {
            CurrentMagazine -= 3;
        }
    }
}
