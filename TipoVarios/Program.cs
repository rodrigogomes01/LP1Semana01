using System;

namespace TipoVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Integral variables
            byte number1 = 12;
            sbyte number2 = -2;
            int number3 = 84387;

            /// Print the integral variables
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            /// Char variables
            char north = '\u00A9';
            char south = '\u00A3';
            char east = '\u0EAF';

            /// Print the char variables
            Console.WriteLine(north);
            Console.WriteLine(south);
            Console.WriteLine(east);

            /// Real variables
            float Numberfloat = 2.3f;
            double Numberdouble = 2.343;
            decimal Numberdecimal = 8.73m;

            /// Print the real variables
            Console.WriteLine(Numberfloat);
            Console.WriteLine(Numberdouble);
            Console.WriteLine(Numberdecimal);
        }
    }
}
