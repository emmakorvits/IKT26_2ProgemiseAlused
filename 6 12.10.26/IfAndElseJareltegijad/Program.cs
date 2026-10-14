namespace IfAndElseJareltegijad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta auto läbisõit kilomeetrites.");
            int voimsus = int.Parse(Console.ReadLine());

            if (voimsus <= 20000 && voimsus >= 0)
            {
                Console.WriteLine("Sino auto on läbinud " + voimsus);
                Console.WriteLine("km");
            }
            if (voimsus <= 130000 && voimsus >= 20001)
            {
                Console.WriteLine("Sinu auto on läbinud " + voimsus);
                Console.WriteLine("km");
            }
            if (voimsus <= 170000 && voimsus >= 130001)
            {
                Console.WriteLine("Sinu auto on läbinud " + voimsus);
                Console.WriteLine("km");
            }
            if (voimsus >= 170001)
            {
                Console.WriteLine("Sinu auto on läbinud " + voimsus);
                Console.WriteLine("km");
            }
        }
    }
}
