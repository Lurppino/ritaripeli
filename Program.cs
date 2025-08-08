namespace ritaripeli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa pelaamaan ritaripeliä");
            Ritaripeli peli = new Ritaripeli();
            peli.PeliSilmukka();
        }
    }
}
