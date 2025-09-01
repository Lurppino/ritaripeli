using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritaripeli
{
	internal class Ritaripeli
	{
		Ritari pelaaja;
		List<Hirviö> hirviot;
		List<IKauppa> kaupat;
        public Ritaripeli()
        {
            pelaaja = new Ritari("Sankari", aloitusOsumapisteet: 10, aloitusRahat: 10);

            
            hirviot = new List<Hirviö>()
			{
					new Goblin()
			};

            kaupat = new List<IKauppa>()
			{
				new NuoliKauppa(),
                new RuokaKauppa()
            };
        }

        public void PeliSilmukka()
        {
            while (true)
            {
                Console.WriteLine($"\nTilanne: HP {pelaaja.Osumapisteet}, Kultaa {pelaaja.Rahapussi.Rahoja}");
                Console.WriteLine("Valitse toiminto:");
                Console.WriteLine("1. Mene nuolikauppaan");
                Console.WriteLine("2. Mene ravintolaan");
                Console.WriteLine("3. Lähde taisteluun");
                Console.WriteLine("4. Käytä esinettä repusta");
                Console.Write("> ");

                int valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        KauppaTila(kaupat[0]);
                        break;
                    case 2:
                        KauppaTila(kaupat[1]);
                        break;
                    case 3:
                        TaisteluTila();
                        break;
                    case 4:
                        pelaaja.Reppu.ShowInventory();
                        break;
                }

                if (pelaaja.Osumapisteet <= 0)
                {
                    Console.WriteLine("Hävisit pelin!");
                    break;
                }
            }
        }


        public void TaisteluTila()
        {
            Hirviö vastustaja = hirviot[0];
            Console.WriteLine($"Kohtaat hirviön: {vastustaja.Nimi}!");

            while (vastustaja.Osumapisteet > 0 && pelaaja.Osumapisteet > 0)
            {
                Console.WriteLine($"\nOma HP: {pelaaja.Osumapisteet} / Vihollinen HP: {vastustaja.Osumapisteet}");
                Console.WriteLine("1. Hyökkää");
                Console.WriteLine("2. Käytä esinettä");
                Console.WriteLine("3. Pakene");
                Console.Write("> ");

                int valinta = int.Parse(Console.ReadLine());

                if (valinta == 1)
                {
                    int vahinko = 2;
                    Console.WriteLine($"Aiheutat {vahinko} vahinkoa!");
                    vastustaja.OtaVahinkoa(vahinko);
                }
                else if (valinta == 2)
                {
                    pelaaja.Reppu.ShowInventory();
                    Console.WriteLine("Valitse esine:");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    pelaaja.KaytaTavara(index);
                }
                else if (valinta == 3)
                {
                    Console.WriteLine("Pakenet taistelusta!");
                    return;
                }

                if (vastustaja.Osumapisteet > 0)
                {
                    int enemyDamage = vastustaja.AnnaVahinko();
                    pelaaja.Osumapisteet -= enemyDamage;
                    Console.WriteLine($"{vastustaja.Nimi} iskee ja aiheuttaa {enemyDamage} vahinkoa!");
                }
            }

            if (pelaaja.Osumapisteet > 0)
                Console.WriteLine("Voitit hirviön!");
        }


        public void KauppaTila(IKauppa kauppa)
        {
            while (true)
            {
                Console.WriteLine("Valitse toiminto:");
                Console.WriteLine("1. Listaa tavarat");
                Console.WriteLine("2. Osta tavara");
                Console.WriteLine("3. Poistu");

                int valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        var tavarat = kauppa.ListaaTavarat();
                        for (int i = 0; i < tavarat.Count; i++)
                            Console.WriteLine($"{i}: {tavarat[i].Esine.Nimi} {tavarat[i].Hinta} kr");
                        break;

                    case 2:
                        Console.WriteLine("Mikä tavara?");
                        int tavaraValinta = int.Parse(Console.ReadLine());
                        var ostettu = kauppa.OstaTavara(tavaraValinta, pelaaja.Rahapussi);
                        if (ostettu != null)
                            pelaaja.Reppu.AddItem(ostettu);
                        break;

                    case 3:
                        return;
                }
            }
        }

    }
}
