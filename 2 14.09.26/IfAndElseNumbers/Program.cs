namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda vanus");

            //peate kasutama if and else lauseid,
            //et kontrollida, kas kasutaja vanus
            //on suurem kui 18 või väiksem kui 18

            //saab kasutada Converti ja Parse-t
            //int userAge = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            int age = int.Parse(input);

            if(age > 17)
            { Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("täisealine");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("alakas");

            }
        }
    }
}
