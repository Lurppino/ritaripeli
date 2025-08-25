using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritaripeli
{
	/// <summary>
	/// Tästä luokasta peritään kaikki erilaiset 
	/// tavarat joita voi säilyttää repussa
	/// </summary>
	internal abstract class Tavara
	{

        public string Nimi { get; protected set; }
        public int Arvo { get; protected set; }

        protected Tavara(string nimi, int arvo)
        {
            Nimi = nimi;
            Arvo = arvo;
        }

        public abstract void Kayta(Ritari ritari);

        public override string ToString()
        {
            return $"{Nimi} (hinta {Arvo})";
        }
    }
}
