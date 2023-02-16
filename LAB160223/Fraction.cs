using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace LAB160223
{
    struct Fraction
    {
        private int _numerator;
        private int _denominator;

        private static int LeastCommonMultiple(int a, int b)
        {
            return (a * b) / GreatestCommonDivisor(a, b);
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }

        public int Denominator
        {
            get { return _denominator; }
            set {
                if (value == 0)
                    throw new ArgumentException("The denominator cannot be 0");
                _denominator = value; 
            }
        }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int lcm = LeastCommonMultiple(a.Denominator, b.Denominator);
            int numerator = a.Numerator * (lcm / a.Denominator) + b.Numerator * (lcm / b.Denominator);
            return new Fraction(numerator, lcm);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int lcm = LeastCommonMultiple(a.Denominator, b.Denominator);
            int numerator = a.Numerator * (lcm / a.Denominator) - b.Numerator * (lcm / b.Denominator);
            return new Fraction(numerator, lcm);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Numerator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator;
            int denominator = a.Denominator * b.Numerator;
            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
