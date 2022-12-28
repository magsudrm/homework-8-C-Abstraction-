using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar_Interface
{
    internal class Eagle:Gun,IGun,IFireable
    {
        public Eagle(string makeCountry) : base(makeCountry)
        {
        }
        public int CurrentMagazine { get; set; }
        public int MagazineCapacity { get; set; }

        public void Fire()
        {
            CurrentMagazine-=2;
        }
    }
}
