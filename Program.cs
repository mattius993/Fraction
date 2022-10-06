namespace Lezione3_es2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(3, 4);
            Fraction f2 = new Fraction(3, 4);

            Console.WriteLine(f1.Sum(f2));
            Console.WriteLine(f1.Mul(f2));
            Console.WriteLine(f1.Div(f2));
            Console.WriteLine(f1.Sub(f2));
            Console.WriteLine(f1.Equals(f2));
        }
    }
}