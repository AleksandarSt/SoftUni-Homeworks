using System;
using System.IO;

namespace EnterNumbers
{
    class EnterNumbers
    {
        const int inputNumbers=10;

        public static void ReadNumber(int start, int end,int counter)
        {
            int number=0;
            Console.WriteLine("Enter number in range {0} <..< {1}", start, end);

            try
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if ((number > start && number < end) && start < end - 1)
                    {
                        Console.WriteLine("Correct input.Number {0} is in range {1} <..< {2}", number, start, end);
                        counter++;

                        if (counter > 0)
                        {
                            start = number;
                        }
                    }
                    else
                    {

                        if (start==(end-1))
                        {
                            throw new CustomUserException("There is no more numbers in range.");
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("Number out of range!"); 
                        }
                        
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid number.");


                }
            }
            catch (CustomUserException)
            {
                Console.WriteLine("There is no more integer numbers in range {0} <..< {1}.\nProgram will be terminated. ", start,
                            end);
                counter = inputNumbers;
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine(
                    "Number {2} is out of the range {0} <..< {1}\nPlease enter valid number {0} <..< {1} this time...",
                    start, end, number);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number.\nPlease enter valid number {0} <..< {1} this time...", start, end);
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
