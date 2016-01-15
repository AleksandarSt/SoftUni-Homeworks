using System;
using System.Linq;
using System.Text;

namespace LittleJohn
{
    class LittleJohnMain
    {
        private static void Main()
        {
            const string SmallArrow = ">----->";
            const string MediumArrow = ">>----->";
            const string LargeArrow = ">>>----->>";

            string[] input = new string[4];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }

            int smallArrowCount = 0;
            int mediumArrowCount = 0;
            int largeArrowCount = 0;

            var currentLine = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                currentLine.Append(input[i]);
                //int startIndex = 0;

                //count large arrows
                while (currentLine.ToString().Contains(LargeArrow))
                {
                    int startIndex = currentLine.ToString().IndexOf(LargeArrow);
                    currentLine.Remove(startIndex, LargeArrow.Count());
                    currentLine.Insert(startIndex, "*");
                    largeArrowCount++;
                }

                //count medium arrows
                while (currentLine.ToString().Contains(MediumArrow))
                {
                    int startIndex = currentLine.ToString().IndexOf(MediumArrow);
                    currentLine.Remove(startIndex, MediumArrow.Count());
                    currentLine.Insert(startIndex, "*");
                    mediumArrowCount++;
                }

                //count small arrows
                while (currentLine.ToString().Contains(SmallArrow))
                {
                    int startIndex = currentLine.ToString().IndexOf(SmallArrow);
                    currentLine.Remove(startIndex, SmallArrow.Count());
                    currentLine.Insert(startIndex, "*");
                    smallArrowCount++;
                }

                currentLine.Clear();
            }

            int decimalMessage =
                int.Parse(smallArrowCount.ToString() + mediumArrowCount.ToString() + largeArrowCount.ToString());

            char[] binaryMessage = Convert.ToString(decimalMessage, 2).ToCharArray();

            char[] binaryReversedMessage = binaryMessage.Reverse().ToArray();

            int finalEncryptedMessage = 0;

            char[] concatenatedMessage = new char[binaryMessage.Length*2];

            for (int i = 0; i < concatenatedMessage.Length; i++)
            {
                if(i<binaryMessage.Length)
                {
                    concatenatedMessage[i] = binaryMessage[i];
                }
                else
                {
                    concatenatedMessage[i] = binaryReversedMessage[i - binaryMessage.Length];
                }
                
            }

            for (int j = 0; j < concatenatedMessage.Length; j++)
            {
                int currentValue = int.Parse(concatenatedMessage[j].ToString());
                if (currentValue == 1)
                {
                    finalEncryptedMessage = finalEncryptedMessage + (int) (Math.Pow(2, j));
                }
            }

            Console.WriteLine(finalEncryptedMessage);
        }
    }
}
