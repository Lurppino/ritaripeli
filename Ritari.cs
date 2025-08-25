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
		private Reppu reppu { get; set; }
		public Lompakko rahapussi;

		public Ritari(int aloitusOsumapisteet, int aloitusRahat)
		{
			Osumapisteet = aloitusOsumapisteet;
			rahapussi = new Lompakko(aloitusRahat);
			reppu = new Reppu();
		}

	}
}
