using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main()
        {
            Console.WriteLine("Enter array elements ...");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            StringBuilder currentString=new StringBuilder();

            List<string> list=new List<string>();

            int counter = 0;
            int maxCounter = int.MinValue;
            int numbersCounter=0;
            bool isLongest = false;

            int maxSeqIndex=0;

            while (true)
            {
                if (counter >= array.Length - 1)
                {
                    break;
                }
                isLongest = false;
                numbersCounter = 0;
                currentString.Append(array[counter] + " ");
                do
                {
                    if (counter >= array.Length - 1)
                    {
                        break;
                    }
                    if (array[counter] < array[counter + 1])
                    {
                        currentString.Append(array[counter + 1] + " ");
                        numbersCounter++;
                        if (maxCounter < numbersCounter)
                        {
                            maxCounter = numbersCounter;
                            isLongest = true;

                        }
                        counter++;
                    }
                    else
                    {
                        //counter++;
                        break;
                    }
                    if (counter >= array.Length-1)
                    {
                        break;
                    }
                } while (array[counter] < array[counter + 1]);

                //if (counter<array.Length-1&&array[counter] != array[counter + 1])
                //{
                    counter++;
               // }

                list.Add(currentString.ToString());
                if (isLongest)
                {
                    maxSeqIndex = list.Count-1;
                }
                currentString.Clear();
                if (counter >= array.Length - 1)
                {
                    break;
                }
            }


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("Longest {0}",list[maxSeqIndex]);

        }
    }
}
