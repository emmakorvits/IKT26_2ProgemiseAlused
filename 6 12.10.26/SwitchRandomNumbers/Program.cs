namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerib numbreid ühest kuueni");

            
            int randomNumber = new Random().Next(1, 7);

            //kasutada switchi
            //peab kontrollima tulemust ja kuvama vastavat sõnumit
            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("Number on 1");
                    break;
                case 2:
                    Console.WriteLine("Number on 2");
                    break;
                case 3:
                    Console.WriteLine("Number on 3");
                    break;
                case 4:
                    Console.WriteLine("Number on 4");
                    break;
                case 5:
                    Console.WriteLine("Number on 5");
                    break;
                case 6:
                    Console.WriteLine("Number on 6");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
