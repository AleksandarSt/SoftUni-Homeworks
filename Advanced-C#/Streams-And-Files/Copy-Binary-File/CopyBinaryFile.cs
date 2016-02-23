using System;
using System.IO;

namespace Copy_Binary_File
{
    class CopyBinaryFile
    {
        static void Main()
        {
            using (FileStream source = new FileStream("../../cat.png", FileMode.Open))
            {
                using (FileStream destination = new FileStream("../../cat-copy.png", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }

            Console.WriteLine("Copying done, please check your project folder.");
        }
    }
}
