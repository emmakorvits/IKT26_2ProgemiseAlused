using System.Threading.Channels;

namespace SwitchTööJäreltöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali oma valik:n\\n1. Lahuta 2 numbrit\n2. Tere Tulemast\n3. Lemmiktoit\n4. Välju (Exit)\n");
            Console.Write("Sinu valik: ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Sisesta esimene number.");
                    float firstNr = float.Parse(Console.ReadLine());
                    Console.WriteLine("Vali teine number");
                    float secondNr = float.Parse(Console.ReadLine());
                    Console.WriteLine($"lahutamise tulemus: {firstNr} - {secondNr} = {firstNr * secondNr}");
                    break;

                case 2:
                    Console.WriteLine("Kui soovid meetodit välja kutsuda, siis kirjuta ja");
                    {
                        HelloMethod();
                    }
                    Console.WriteLine("Meetod kutsuti välja");
                    break;

                case 3:
                    Console.WriteLine("Mis on sinu lemmiktoit?");
                    string lemmiktoit = (Console.ReadLine());
                    Console.WriteLine("Sinu lemmiktoit on " + lemmiktoit);
                    break;

            }

            static void HelloMethod()
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
