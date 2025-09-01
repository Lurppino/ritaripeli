namespace ritaripeli
{
    internal class Ritari
    {
        public string Nimi { get; private set; }
        public int Osumapisteet { get; set; }
        public Lompakko Rahapussi { get; private set; }
        public Reppu Reppu { get; private set; }

        public Ritari(string nimi, int aloitusOsumapisteet, int aloitusRahat)
        {
            Nimi = nimi;
            Osumapisteet = aloitusOsumapisteet;
            Rahapussi = new Lompakko(aloitusRahat);
            Reppu = new Reppu();
        }

        
        public void KaytaTavara(int index)
        {
            var tavarat = Reppu.ReturnItem();
            if (index < 0 || index >= tavarat.Count)
            {
                Console.WriteLine("Virheellinen valinta!");
                return;
            }

            Tavara valittu = tavarat[index];
            valittu.Kayta(this);
            Reppu.RemoveItem(valittu);
        }
    }
}
