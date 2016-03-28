using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Series_of_letters
{
    class SeriesOfLetters
    {
        static void Main()
        {

            /*Write a program that reads a string 
             * from the console and replaces all series of consecutive identical letters with a single one.*/

            var text = Console.ReadLine();
            string pattern = @"(.)\1+";
            var regex = new Regex(pattern);
            Console.WriteLine(regex.Replace(text, "$1"));

        }
    }
}
