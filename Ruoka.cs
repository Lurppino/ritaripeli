using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritaripeli
{
    internal class Ruoka : Tavara
    {
        public int Elvytys { get; private set; }  

        public Ruoka(string nimi, int arvo, int elvytys) : base(nimi, arvo)
        {
            Elvytys = elvytys;
        }

        public override void Kayta(Ritari ritari)
        {
            ritari.Osumapisteet += Elvytys;
            Console.WriteLine($"{ritari.Nimi} söi {Nimi} ja parani {Elvytys} osumapistettä!");
        }
    }
}
