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
				new NuoliKauppa()
			};
        }

        public void PeliSilmukka()
        {
            while (true)
            {
                Console.WriteLine($"\nTilanne: HP {pelaaja.Osumapisteet}, Kultaa {pelaaja.Rahapussi.Rahoja}");
                Console.WriteLine("Valitse toiminto:");
                Console.WriteLine("1. Mene nuolikauppaan");
                Console.WriteLine("2. Lähde taisteluun");
                Console.WriteLine("3. Käytä esinettä repusta");
                Console.Write("> ");

                int valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        KauppaTila();
                        break;
                    case 2:
                        TaisteluTila();
                        break;
                    case 3:
                        pelaaja.Reppu.ShowInventory();
                        Console.WriteLine("Valitse esine käytettäväksi:");
                        int index = int.Parse(Console.ReadLine()) - 1;
                        pelaaja.KaytaTavara(index);
                        break;
                    default:
                        Console.WriteLine("Virheellinen valinta!");
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


        public void KauppaTila()
		{
			// TODO anna pelaajan valita mihin kauppaan pelaaja menee
			// listaa kaupan tavarat ja anna pelaajan valita minkä hän haluaa
			// yrittää ostaa
			// lisää vaihtoehto jolla pelaaja pääsee pois kaupasta ja Kauppatilasta
		}
	}
}
