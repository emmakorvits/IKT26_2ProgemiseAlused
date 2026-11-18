namespace WhileGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arva ära number vahemikus 1 - 101!");

            //numbri arvamise mäng

            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 1;

            //tuleb kasutada while, kus öeldakse, kas sinu
            //pakutud number oli suurem või väiksem

            while (secretNumber != guess)
            {
                guess = int.Parse(Console.ReadLine());
                Console.WriteLine("katseid: " + attempts);
                
                if (guess < secretNumber)
                {
                    Console.WriteLine("Number on suurem");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Number on väiksem");
                }
                else
                {
                    Console.WriteLine("Arvasid ära!");
                }
                attempts++;

            }
        }
    }
}
