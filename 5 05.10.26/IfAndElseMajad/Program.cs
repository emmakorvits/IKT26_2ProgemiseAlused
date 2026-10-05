namespace IfAndElseMajad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on sinu maja suurus?");
            
            int voimsus = int.Parse(Console.ReadLine());

            if (voimsus >= 0 && voimsus <= 40)
            {
                Console.WriteLine("Sinu maja suurus on " + voimsus);
           
            }

            if (voimsus >= 90 && voimsus <= 41)
            {
                Console.WriteLine("Sinu maja suurus on " + voimsus);
                
            }

            if (voimsus <= 130 && voimsus <= 91)
            {
                Console.WriteLine("Sinu maja suurus on " + voimsus);
                
            }

            if (voimsus >= 131)
            {
                Console.WriteLine("Sinu maja suurus on " + voimsus);
                
            }
        }
    }
}
       