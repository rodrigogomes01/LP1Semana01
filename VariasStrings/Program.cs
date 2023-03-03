using System;

namespace VariasStrings
{
    class Program
    {

        static void Main(string[] args)
        {

            ///Added new variables
            double xx = 0.12345;
            int ii = 18;

            /// String variables
            string normal = "\tThis is a normal string\n";
            string verbatim = @"This is a more special string""That allows this"" To be more special";

            ///Print the string variables
            Console.WriteLine(normal);
            Console.WriteLine(verbatim);

            int x = 10;
            int y = 20;

            ///Concentration of strings
            string var_conc = "a" + 2;
            string var_conc2 = "abc" + x;

            ///Interpolation of strings
            string interpolation = $"The x value is: {x}";;
            string interpolation2 = $"x + y is equal to: {x + y}";

            ///String format
            string string_form = String.Format("Y is {1}, X is {0}", x, y);

            ///Print new strings
            Console.WriteLine(var_conc);
            Console.WriteLine(var_conc2);
            Console.WriteLine(interpolation);
            Console.WriteLine(interpolation2);
            Console.WriteLine(string_form);

            ///Print the new variables added
            Console.WriteLine($"xx={xx:f2}");
            Console.WriteLine($"xx={xx:p1}");
            Console.WriteLine(ii.ToString("x"));
            Console.WriteLine(ii.ToString("C", CultureInfo.CurrentCulture));
        }
    }
}
