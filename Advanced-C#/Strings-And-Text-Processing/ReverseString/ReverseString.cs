namespace ReverseString
{
    using System;

    class ReverseString
    {
        static void Main()
        {
            char[] textToReverse = Console.ReadLine().ToCharArray();

            Array.Reverse(textToReverse);

            for (int i = 0; i < textToReverse.Length; i++)
            {
                Console.Write(textToReverse[i]);
            }

            Console.WriteLine();
        }
    }
}
