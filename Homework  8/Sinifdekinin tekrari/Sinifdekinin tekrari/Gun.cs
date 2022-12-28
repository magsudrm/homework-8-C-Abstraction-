using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdekinin_tekrari
{
    internal abstract class Gun
    {
        public int CurrentMagazine;
        public int MagazineCapacity;

        public abstract void Fire();
    }
}
