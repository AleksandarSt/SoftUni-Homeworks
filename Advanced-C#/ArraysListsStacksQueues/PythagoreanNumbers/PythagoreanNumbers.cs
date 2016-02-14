using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanNumbers
{
    class PythagoreanNumbers
    {
        static void Main()
        {
            int inputCount = int.Parse(Console.ReadLine());
            int[] Numbers = new int[inputCount];

            for (int i = 0; i < inputCount; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(Numbers);

            bool isPitagoreanEquation = false;

            for (int i = 0; i < inputCount; i++)
            {
                for (int j = i; j < inputCount; j++)
                {
                    for (int k = j; k < inputCount; k++)
                    {
                        if ((Numbers[i] * Numbers[i] + Numbers[j] * Numbers[j]) == (Numbers[k] * Numbers[k]))
                        {
                            isPitagoreanEquation = true;

                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}",Numbers[i],Numbers[j],Numbers[k]);
                        }
                    }
                }
            }

            if (!isPitagoreanEquation)
            {
                Console.WriteLine("No");
            }
        }
    }
}
