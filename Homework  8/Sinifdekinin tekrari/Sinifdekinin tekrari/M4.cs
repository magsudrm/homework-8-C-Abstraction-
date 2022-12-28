using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdekinin_tekrari
{
    internal class M4:Gun
    {
        public override void Fire()
        {
            CurrentMagazine -= 3;
        }
    }
}
