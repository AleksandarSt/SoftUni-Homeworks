using System;

namespace GenericList
{
    class MainProgram
    {
        static void Main()
        {
            GenericList<int> test = new GenericList<int>(1);

            //Add
            test.Add(0);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            test.Add(6);

            TestPrint(test);
            Console.WriteLine();

            //Remove
            test.RemoveAt(4);

            TestPrint(test);

            //Insert at position
            test.InsertAt(6, 4);

            TestPrint(test);

            test.InsertAt(7, 5);

            TestPrint(test);

            //Clear
            //test.Clear();
            //TestPrint(test);

            //Find
            Console.WriteLine(test.Find(4));

            //Contains
            Console.WriteLine(test.Contains(4));

            //Overriden ToString()
            Console.WriteLine(test);
            
            //Min and Max
            Console.WriteLine(test.Min());
            Console.WriteLine(test.Max());
        }

        public static void TestPrint<T>(GenericList<T> test)
            where T: IComparable<T>
        {
            for (int i = 0; i < test.Count; i++)
                    {
                        Console.WriteLine(test[i]);
                    }
                    Console.WriteLine("Count: {0}",test.Count);
        }
    }
}
