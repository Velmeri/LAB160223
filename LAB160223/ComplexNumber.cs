using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB160223
{
    struct ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public ComplexNumber Add(ComplexNumber other)
        {
            return new ComplexNumber(Real + other.Real, Imaginary + other.Imaginary);
        }

        public ComplexNumber Subtract(ComplexNumber other)
        {
            return new ComplexNumber(Real - other.Real, Imaginary - other.Imaginary);
        }

        public ComplexNumber Multiply(ComplexNumber other)
        {
            double real = (Real * other.Real) - (Imaginary * other.Imaginary);
            double imaginary = (Real * other.Imaginary) + (Imaginary * other.Real);
            return new ComplexNumber(real, imaginary);
        }

        public ComplexNumber Divide(ComplexNumber other)
        {
            double divisor = (other.Real * other.Real) + (other.Imaginary * other.Imaginary);
            double real = ((Real * other.Real) + (Imaginary * other.Imaginary)) / divisor;
            double imaginary = ((Imaginary * other.Real) - (Real * other.Imaginary)) / divisor;
            return new ComplexNumber(real, imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}";
        }
    }
}
