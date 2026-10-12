namespace SwitchColour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta värv");

            string värv = Console.ReadLine();
            //kasutada switchi
            //sisestab värvi nime
            //Red, Green, Blue, White, Orange
            //iga värvi puhul näitab vastava konsooli + tekst
            //kui sisestatakse muu värv, siis näitav "Värv puudub"
            switch (värv)
            {
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("Sisestasid värvi Red");
                   
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.WriteLine("Sisestasid värvi Green");
                    
                    break;
                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue; 
                    Console.WriteLine("Sisestasid värvi Blue");
                    
                    break;
                case "White":
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.WriteLine("Sisestasid värvi White");
                    
                    break;
                case "Orange":
                    Console.ForegroundColor = ConsoleColor.DarkYellow; 
                    Console.WriteLine("Sisestasid värvi Orange");
                    
                    break;
                default:
                    Console.WriteLine("Värv puudub");
                    break;

            }
        }
    }
}
