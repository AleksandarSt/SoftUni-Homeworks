using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    class MainProgram
    {
        static void Main()
        {
            AsynchronousTimer asynchronousTimer = new AsynchronousTimer(PrintDateTimeMilliseconds, 10, 1000);
            asynchronousTimer.Run();
        }

        static void PrintDateTimeMilliseconds(DateTime nowDateTime)
        {
            Console.WriteLine(
                "{0}:{1}:{2}.{3}",
                nowDateTime.Hour,
                nowDateTime.Minute,
                nowDateTime.Second,
                nowDateTime.Millisecond);
        }
    }
}
