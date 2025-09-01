using ritaripeli;

internal class NuoliKauppa : IKauppa
{
    private List<TavaraJaHinta> tuotteet;

    public NuoliKauppa()
    {
        tuotteet = new List<TavaraJaHinta>()
        {
            new TavaraJaHinta(new Arrow("Puunuoli", 5, 10), 5),
            new TavaraJaHinta(new Arrow("Teräsnuoli", 15, 25), 15)
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
