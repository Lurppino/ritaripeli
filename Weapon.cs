namespace ritaripeli
{
    internal class Weapon : Tavara
    {
        public int Vahinko { get; private set; } 

        public Weapon(string nimi, int arvo, int vahinko) : base(nimi, arvo)
        {
            Vahinko = vahinko;
        }

        public override void Kayta(Ritari ritari)
        {
            Console.WriteLine($"{ritari.Nimi} equips {Nimi} with {Vahinko} damage.");
        }
    }
}
