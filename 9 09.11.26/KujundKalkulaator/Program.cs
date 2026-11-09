namespace KujundKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leia ruudu pindala ja ümbermõõt, kui ruudu sees asub ring raadiusega 3");

            //Ruudu sees asub ring. Ringi raadius on 3 ühikut
            //Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt

            double diameter = 3 * 2;
            double roundRadius = diameter / 2;
            double pindala = diameter * diameter;
            double ümbermõõt = diameter * 4;

            //arvuta ringi pindala ja ümbermõõt

            double RingiS = 3.14 * 6.00;
            double RingiP = (3.14 * 36.00) / 4.00;

            Console.WriteLine("Ringi pindala: 3.14 * 6.00 = " + RingiS);
            Console.WriteLine("Ringi ümbermõõt: (3.14 * 36.00) / 4.00 = " + RingiP);

            double squareArea1 = Math.Pow(diameter, 2);
            double squareArea2 = diameter * diameter;

            double squarePerimeter = diameter * 4;

            Console.WriteLine("Ruudu pindala: " + Math.Pow(roundRadius, 2));
            Console.WriteLine("Ruudu pindala: " + (diameter * diameter));
            Console.WriteLine("Ruudu ümbermõõt: " + (diameter * 4));






        }
    }
}
