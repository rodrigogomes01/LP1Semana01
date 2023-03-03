using System;

namespace VariasStrings
{
    class Program
    {

        static void Main(string[] args)
        {
            /// String variables
            string normal = "\tThis is a normal string\n";
            string verbatim = @"This is a more special string""That allows this"" To be more special";

            ///Print the string variables
            Console.WriteLine(normal);
            Console.WriteLine(verbatim);
        }
    }
}
