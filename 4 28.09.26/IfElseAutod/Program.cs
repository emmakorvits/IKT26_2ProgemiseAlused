namespace IfElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali automark!");
            //kasutada if and else
            //kirjuta automark
            //valikus on BMW, Audi, Porsche ja Skoda
            //Kui valitakse Skoda, siis seal ees on uuesti küsimus, et
            //mis mudelit soovid valida. Mudeli valikus Kodiaq ja Octavia

           string auto = Console.ReadLine();
            string automark = string.Intern(auto);

            if (automark == "BMW")
            {
                Console.WriteLine("Oled valinud BMW");
            }
            else if (automark == "Audi")
            {
                Console.WriteLine("Oled valinud Audi");
            }
            else if (automark == "Porsche")
            {
                Console.WriteLine("Oled valinud Porsche");
            }
            else if (automark == "Skoda")
            {
                Console.WriteLine("Mis mudelit soovid valida?");
                string mudel = Console.ReadLine();

                if (mudel == "Kodiaq")
                {
                    Console.WriteLine("Valisid Kodiaq");
                }
                if (mudel == "Octavia")
                {
                    Console.WriteLine("Valisid Octavia");
                }
            }
        }
    }
}
