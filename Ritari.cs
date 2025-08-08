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
		// TODO private Reppu reppu;
		public Lompakko rahapussi;

		public Ritari(int aloitusOsumapisteet, int aloitusRahat)
		{
			Osumapisteet = aloitusOsumapisteet;
			rahapussi = new Lompakko(aloitusRahat);
			// TODO luo tyhjä Reppu
		}

	}
}
