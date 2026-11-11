namespace ForLoopHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //teha konsoolirakendus, kus kasutad for loopi
            //kolm korda näidatakse Tere tulemast reaNumber

            int loop = 3;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Tere tulemast " + i);
            }

        }
    }
}
