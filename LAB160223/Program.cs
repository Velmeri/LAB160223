using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB160223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fraction
            {
                Fraction a = new Fraction(1, 2);
                Fraction b = new Fraction(3, 4);
                Fraction c = a + b;
                Console.WriteLine(c);
                Fraction d = a - b;
                Console.WriteLine(d);
                Fraction e = a * b;
                Console.WriteLine(e);
                Fraction f = a / b;
                Console.WriteLine(f);
            }

            // Complex number
            {
                Console.WriteLine();
                ComplexNumber a = new ComplexNumber(1, 2);
                ComplexNumber b = new ComplexNumber(3, 4);
                ComplexNumber c = a.Add(b); 
                Console.WriteLine(c);
                ComplexNumber d = a.Subtract(b);
                Console.WriteLine(d);
                ComplexNumber e = a.Multiply(b);
                Console.WriteLine(e);
                ComplexNumber f = a.Divide(b);
                Console.WriteLine(f);
            }

            {
                Console.WriteLine();
                Birthday birthday = new Birthday(new DateTime(1990, 4, 1));
                DayOfWeek dayOfWeek = birthday.GetDayOfWeek(); 
                Console.WriteLine(dayOfWeek);
                DayOfWeek dayOfWeekInYear = birthday.GetDayOfWeekInYear(2025); 
                Console.WriteLine(dayOfWeekInYear);
                int daysUntilNextBirthday = birthday.GetDaysUntilNextBirthday();
                Console.WriteLine(daysUntilNextBirthday);
            }

            Console.ReadKey();
        }
    }
}
