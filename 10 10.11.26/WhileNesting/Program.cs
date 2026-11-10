using System.Runtime.InteropServices;

namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //tuleb kasutada while ja omakorda while sisse panna while
            //while nesting
            //while kordab ennast 5 korda
            //vooskeem teha

            int ValimineNr = 1;

            while (ValimineNr <= 5)
            {
                Console.WriteLine();

                int SisemineNr = 1;

                while (SisemineNr <= 5)
                {
                    Console.Write(SisemineNr + " ");

                    SisemineNr++;
                }
                ValimineNr++;
            }
        }
    }
}
