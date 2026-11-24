namespace TriangleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest kolmnurk, täisnurkne kolmnurk");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta ridade arv: ");
            int i, j, rows;
            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= rows; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.WriteLine("*");
                }
                Console.Write("\n");
            }
        }
    }
}
