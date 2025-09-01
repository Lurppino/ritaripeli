namespace ritaripeli
{
    internal class Arrow : Tavara
    {
        public int Damage { get; private set; }

        public Arrow(string nimi, int arvo, int damage) : base(nimi, arvo)
        {
            Damage = damage;
        }

        public override void Kayta(Ritari ritari)
        {
            Console.WriteLine($"{ritari.Nimi} shoots a {Nimi} arrow for {Damage} damage!");
        }
    }
}
