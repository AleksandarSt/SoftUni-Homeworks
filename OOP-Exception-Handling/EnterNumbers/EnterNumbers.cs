using System;

namespace EnterNumbers
{
    class EnterNumbers
    {
        const int inputNumbers=10;

        public static void ReadNumber(int start, int end,int counter)
        {
            int number=0;
            Console.WriteLine("Enter number in range [{0}..{1}]", start, end);

            try
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= start && number <= end)
                    {
                        Console.WriteLine("Correct input.Number {0} is in range [{1}..{2}]", number, start, end);
                        counter++;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Number" + number + "is out of the range [" + start + ".." +
                                                              end + "]");
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid number.");


                }
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("Number {2} is out of the range [{0}..{1}]\nPlease enter valid number[{0}..{1}] this time...", start, end,number);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number.\nPlease enter valid number[{0}..{1}] this time...",start,end);
            }
            finally
            {
                if (counter < inputNumbers)
                {
                    ReadNumber(start, end, counter);
                }
                else
                {

                    Console.WriteLine("End of program!");
                }
                
            }

        }

        static void Main()
        {
            int start = 1;
            int end = 100;
            int counter = 0;

            ReadNumber(start,end,counter);
        }
    }
}
