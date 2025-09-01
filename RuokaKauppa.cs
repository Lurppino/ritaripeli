using System;
using System.Collections.Generic;

namespace ritaripeli
{
    internal class RuokaKauppa : IKauppa
    {
        private List<TavaraJaHinta> tuotteet;

        public RuokaKauppa()
        {
            tuotteet = new List<TavaraJaHinta>()
            {
                new TavaraJaHinta(new Ruoka("Leipä", 5, 3), 5),
                new TavaraJaHinta(new Ruoka("Keitto", 10, 7), 10),
                new TavaraJaHinta(new Ruoka("Kultainen Omena", 25, 20), 25)
            };
        }

        public List<TavaraJaHinta> ListaaTavarat()
        {
            return tuotteet;
        }

        public Tavara? OstaTavara(int valittuTavara, Lompakko rahapussi)
        {
            if (valittuTavara < 0 || valittuTavara >= tuotteet.Count)
            {
                Console.WriteLine("Virheellinen valinta!");
                return null;
            }

            TavaraJaHinta valinta = tuotteet[valittuTavara];

            int maksettu = rahapussi.OtaRahaa(valinta.Hinta);
            if (maksettu == valinta.Hinta)
            {
                Console.WriteLine($"Ostit: {valinta.Esine.Nimi} ({valinta.Hinta} kultaa)");
                return valinta.Esine;
            }
            else
            {
                Console.WriteLine("Sinulla ei ole tarpeeksi kultaa!");
                return null;
            }
        }
    }
}
