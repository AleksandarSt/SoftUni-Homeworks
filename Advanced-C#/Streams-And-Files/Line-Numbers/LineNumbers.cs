using System;
using System.IO;

namespace Line_Numbers
{
    class LineNumbers
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("../../TextToRead.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../TextWithLineNumbers.txt"))
                {

                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;
                        writer.WriteLine("Line {0}: {1}", lineNumber, line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
