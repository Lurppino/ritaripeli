using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritaripeli
{
    internal class Goblin : Hirviö
    {
        public Goblin()
        {
            Nimi = "Goblin";
            Osumapisteet = 5;
        }

        public override int AnnaVahinko() => 2;
        public override void OtaVahinkoa(int maara) => Osumapisteet -= maara;
    }
}
