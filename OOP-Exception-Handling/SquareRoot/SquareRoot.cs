using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException("Number should be positive or 0.");
                }

                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number cannot be negative.");
            }
            catch (ArgumentException)
            {

                Console.WriteLine("Invalid number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}
