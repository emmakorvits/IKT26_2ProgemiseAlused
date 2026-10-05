namespace IfAndElsePikkus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on sinu pikkus?");

            int voimsus = int.Parse(Console.ReadLine());

            if (voimsus >= 40 && voimsus <= 80)
            {
                Console.WriteLine("Sinu pikkus on " + voimsus);

            }

            if (voimsus >= 130 && voimsus <= 81)
            {
                Console.WriteLine("Sinu pikkus on " + voimsus);

            }

            if (voimsus <= 170 && voimsus <= 131)
            {
                Console.WriteLine("Sinu pikkus on " + voimsus);

            }

            if (voimsus >= 171)
            {
                Console.WriteLine("Sinu pikkus on " + voimsus);

            }
        }
    }
}