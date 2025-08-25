using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritaripeli
{
    internal class Ruoka : Tavara
    {
        public int Restoration { get; private set; }  

        public Ruoka(string nimi, int arvo, int restoration) : base(nimi, arvo)
        {
            Restoration = restoration;
        }

        public override void Kayta(Ritari ritari)
        {
            ritari.Osumapisteet += Restoration;
            Console.WriteLine($"{ritari.Nimi} söi {Nimi} ja parani {Restoration} osumapistettä!");
        }
    }
}
