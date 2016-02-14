using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSums
{
    class SubsetSums
    {
        static void Main()
        {
            Console.WriteLine("Enter number N...");
            int sum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter array elements ...");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();

            List<int> currSeq = new List<int>();
            List<string> seqStr = new List<string>();

            int combinations = (int)Math.Pow(2, array.Length);

            for (int i = 0; i < combinations; i++)
            {
                currSeq.Clear();

                for (int j = 0; j < array.Length; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = i & mask;
                    int bit = iAndMask >> j;

                    if (bit == 1)
                    {
                        currSeq.Add(array[j]);
                    }
                }

                if (currSeq.Sum() == sum && (string.Join(" + ", currSeq)!=String.Empty)) 
                {
                    //Console.WriteLine("{0} = {1}", string.Join(" + ", currSeq), sum);
                    seqStr.Add(string.Join(" + ", currSeq) + " = " + sum);
                }
            }

            if (seqStr.Count==0)
            {
                Console.WriteLine("No matching subsets.");
            }
            else
            {
                for (int i = 0; i < seqStr.Count; i++)
                {
                    Console.WriteLine(seqStr[i]);
                }
            }
        }
    }
}
