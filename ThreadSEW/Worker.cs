using System;
using System.Threading;

namespace ThreadSEW
{
    public class Worker
    {
        public static void Work1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Work 1: {i}");
                Thread.Sleep(5);
            }
        }
        
        public static void Work2()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Work 2: {i}");
                Thread.Sleep(5);
            }
        }
    }
}