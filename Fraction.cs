using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione3_es2
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }



        public Fraction Sum(Fraction f)
        {
            int mcm = Mcm(f);
            Fraction fraction = new Fraction(((mcm / this.denominator) * this.numerator) + ((mcm / f.denominator) * f.numerator), mcm);
            return fraction.Semplify();
        }

        public Fraction Mul(Fraction f)
        {
            Fraction fraction = new Fraction(numerator * f.numerator, denominator * f.denominator);

            return fraction.Semplify();
        }

        public Fraction Div(Fraction f)
        {
            Fraction fraction = new Fraction(f.denominator, f.numerator);
            fraction = Mul(fraction);
            return fraction.Semplify();
        }

        public Fraction Sub(Fraction f)
        {
            int mcm = Mcm(f);
            Fraction fraction = new Fraction(((mcm / this.denominator) * this.numerator) - ((mcm / f.denominator) * f.numerator), mcm);
            return fraction.Semplify();
        }

        public override bool Equals(object? obj)
        {

            Fraction fraction1 = Semplify();
            Fraction fraction2;
            if(obj != null)
            {
                fraction2 = (Fraction)obj;
                fraction2.Semplify(); 
                if ((fraction1.numerator == fraction2.numerator) && (fraction1.denominator == fraction2.denominator))
                {
                    return true;
                }
            }        
                       
            return false;
            
        }

        public Fraction Semplify()
        {
            int mcd = Mcd(numerator, denominator);
            if (mcd != denominator)
            {
                numerator = numerator / mcd;
                denominator = denominator / mcd;
            }
            return new Fraction(numerator, denominator);
        }
        public override string ToString()
        {
            return numerator + "\n___\n" + denominator;
        }
        public int Mcm(Fraction f)
        {

            return (int)((denominator * f.denominator) / Mcd(denominator, f.denominator));
        }
        public int Mcd(int a, int b)
        {
            int resto = 0;

            while (b != 0)
            {
                resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
