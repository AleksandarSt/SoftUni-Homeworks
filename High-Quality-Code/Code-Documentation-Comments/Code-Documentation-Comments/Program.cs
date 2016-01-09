using System;

namespace Code_Documentation_Comments
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "Some text";
            var result = input.ToMd5Hash();
            Console.WriteLine(input.ToByteArray());
        }
    }
}
