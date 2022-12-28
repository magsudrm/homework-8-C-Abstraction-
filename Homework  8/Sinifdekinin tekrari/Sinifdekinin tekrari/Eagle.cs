using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdekinin_tekrari
{
    internal class Eagle:Gun
    {
        public override void Fire()
        {
            CurrentMagazine-=2;
        }
    }
}
