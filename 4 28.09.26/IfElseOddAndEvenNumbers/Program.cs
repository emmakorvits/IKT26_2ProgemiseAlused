namespace IfElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //konsool küsib numbrit
            //number tuleb ära parsida

            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number % 2 == 0)
            {
                Console.WriteLine("Arv on paaris");
            }
            else
            {
                Console.WriteLine("Arv on paaritu");
            }
            //if ja else juures toimub kontroll, et
            //kas on paaris või paaritu number

            //kutsuda paarisarvu ja paaritu arvu tekst välja
            //läbi meetodi kutsumise

            Console.WriteLine("Kutsu paarisarvu ja paaritu arvu tekst välja läbi meetodi");
            string vastus = Console.ReadLine();

            if (vastus = % 2 == 0)
            {
                NumberMethod();
            }
            else
            {
                Console.WriteLine("Meetodit ei kutsutud välja");
            }

            static void NumberMethod()
            {
                Console.WriteLine();
            }
        }
    }
}
