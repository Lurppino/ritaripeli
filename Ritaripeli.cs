﻿using System;
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
			// TODO arvo pelaajaa vastaan taisteleva hirviö
			Hirviö vastustaja = null;
			while (vastustaja.Osumapisteet > 0 && pelaaja.Osumapisteet > 0)
			{
				// TODO anna pelaajan valita toiminto:
				// 1. hyökkää : aiheuta vahinkoa hirviölle
				// 2. käytä esinettä ; näytä Repun sisältö ja anna pelaajan valita tavara
				// Jos pelaaja käyttää ruoka-annosta, lisää pelaajan osumapisteitä
				// Jos pelaaja käyttää nuolta, ammu nuoli kohti vihollista
				// Jos pelaaja käyttää jotain muuta tavaraa, toimi valinnan mukaan
				// 3. pakene : poistu TaisteluTilasta

				// TODO Jos hirviöllä on osumapisteitä jäljellä
				// arvo hirviön tekemä vahinko ja vähennä se pelaajan osumapisteistä
			}
			// Kun taistelu loppuu, palaa PeliSilmukkaan
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
