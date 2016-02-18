using System;
using System.Text;

namespace Text_Filter
{
    class TextFilter
    {
        static void Main()
        {
            const char censorSymbol = '*';

            char[] separator = new[] {',', ' '};

            string[] bannedWords = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            string textToCensore = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(textToCensore);

            for (int i = 0; i < bannedWords.Length; i++)
            {
                sb.Replace(bannedWords[i], new string(censorSymbol, bannedWords[i].Length));
            }

            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
            }

            Console.WriteLine();
        }
    }
}
