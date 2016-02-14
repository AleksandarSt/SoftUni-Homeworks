using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesOfEqualStrings
{
    class SequencesOfEqualStrings
    {
        static void Main()
        {
            do
            {
                Console.WriteLine("Enter array elements ...");
                string[] array = Console.ReadLine().Split(' ');
                string[] distinct = array.Distinct().ToArray();


                for (int i = 0; i < distinct.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (distinct[i] == array[j])
                        {
                            Console.Write("{0} ", distinct[i]);
                        }
                    }
                    Console.WriteLine();
                } 

            } while (true);
 
        }
    }
}
