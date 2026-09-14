namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi");

            //siin on muutuja nimega name
            //mis on tüübiga string
            //loeb andmeid konsoolist ja salvestab
            //need muutuja nime sisse
            string name = Console.ReadLine();

            if (name != "")
            {
                Console.WriteLine("Tere, " + name);
            }
            else
            {
                Console.WriteLine("tere, tundmatu!");
            }
        }
    }
}
