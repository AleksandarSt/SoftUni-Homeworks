using System;

namespace StringLength
{
    class StringLength
    {
        static void Main()
        {
            const int maxAllowedLength=20;
            const char additionalSymbol = '*';
            string input = Console.ReadLine();

            if (input.Length >= maxAllowedLength)
            {
                for (int i = 0; i < maxAllowedLength; i++)
                {
                    Console.Write(input[i]);
                }
            }
            else
            {
                for (int i = 0; i < maxAllowedLength; i++)
                {
                    Console.Write(i < input.Length ? input[i] : additionalSymbol);
                }
            }

            Console.WriteLine();
        }
    }
}
