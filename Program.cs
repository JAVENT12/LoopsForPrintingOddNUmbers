using System;

namespace PrintingOddNumbers
{
    class Program
    {
        static void forOdd()
        {
            Console.WriteLine("\n\tA for loop!");
            for (int i = 0; i < 11;)
            {
                i += 1;
                if (i % 2 != 0)
                {

                    Console.WriteLine(i);
                }
            }
        }
        static void whileOdd()
        {
            Console.WriteLine("\n\tA while loop!");
            int i = 0; while (i < 11)
            {
                i += 1;
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void doOdd()
        {
            Console.WriteLine("\n\tA do loop!");
            int i = 0;
            do
            {
                i += 1;
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            } while (i < 11);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tLet's observe different ways to solve the same problem!");
            forOdd();
            whileOdd();
            doOdd();
        }
    }
}
