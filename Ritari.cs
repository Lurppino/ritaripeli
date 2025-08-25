using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritaripeli
{
	internal class Ritari
	{
		public int Osumapisteet {  get; set; }
        public string Nimi { get; set; }
        private Reppu reppu { get; set; }
		public Lompakko rahapussi;

		public Ritari(string nimi,int aloitusOsumapisteet, int aloitusRahat)
		{
            Nimi = nimi;
            Osumapisteet = aloitusOsumapisteet;
			rahapussi = new Lompakko(aloitusRahat);
			reppu = new Reppu();
		}

	}
}
