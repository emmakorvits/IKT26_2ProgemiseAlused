namespace IfAndElse1ryhm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sinu auto mootori võimsus on ... hj.");
            int voimsus = int.Parse(Console.ReadLine());

            if (voimsus >= 100 && 0 <= 100)
            {
                Console.WriteLine("Sinu auto mootori võimsus on " + voimsus);
                Console.WriteLine("hj");
            }

            if (voimsus >= 150 && 101 <= 150)
            {
                Console.WriteLine("Sinu auto mootori võimsus on " + voimsus);
                Console.WriteLine("hj");
            }

            if (voimsus <= 250 && 151 <= 250 )
            {
                Console.WriteLine("Sinu auto mootori võimsus on " + voimsus);
                Console.WriteLine("hj");
            }

            if (voimsus >= 250 )
            {
                Console.WriteLine("Sinu auto mootori võimsus on " + voimsus);
                Console.WriteLine("hj");
            }
        }
    }
}
