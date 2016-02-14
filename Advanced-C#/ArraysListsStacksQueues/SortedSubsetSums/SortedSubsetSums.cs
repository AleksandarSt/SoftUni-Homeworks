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
            //Reading Input
            Console.WriteLine("Enter number N...");
            int sum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter array elements ...");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();

            List<int> currSeq = new List<int>();

            //List of strings for sequences who meet requirements
            List<string> seqStr = new List<string>();

            //Calculating number of combinations
            int combinations = (int)Math.Pow(2, array.Length);

            //Checking combination and adding sequnces to list if they do
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

                if (currSeq.Sum() == sum && (string.Join(" + ", currSeq) != String.Empty))
                {
                    //Console.WriteLine("{0} = {1}", string.Join(" + ", currSeq), sum);
                    seqStr.Add(string.Join(" + ", currSeq) + " = " + sum);
                }
            }

            //Sorting seqStr
            var seqStrSorted = seqStr
                .OrderBy(x => x.ToString().Split(' ', '+', '=').Length)
                .ThenBy(x => x);

            //Printing output
            if (seqStr.Count == 0)
            {
                Console.WriteLine("No matching subsets.");
            }
            else
            {
                foreach (var item in seqStrSorted)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
