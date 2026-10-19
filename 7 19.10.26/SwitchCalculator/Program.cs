namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number!");
            float input1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Vali tehe: *,/, +, -");
            string input = Console.ReadLine();

            Console.WriteLine("Sisesta teine number");
            float input2 = float.Parse(Console.ReadLine());

            //nüüd tuleb teha switchi valik, kas *, /, +, -
            //tuleb teha neli case, kus toimub soovitud tehe
            //peab näitama tehte tulemust
            //kasutage floati Parsimisel

            switch (input)
            {
                case "*":
                    Console.WriteLine("Vastus on: " + (input1 * input2));
                    break;

                case "/":
                    Console.WriteLine("Vastus on: " + (input1 / input2));
                    break;

                case "+":
                    Console.WriteLine("Vastus on: " + (input1 + input2));
                    break;

                case "-":
                    Console.WriteLine("Vastus om: " + (input1 - input2));
                    break;
            }
        }
    }
}
