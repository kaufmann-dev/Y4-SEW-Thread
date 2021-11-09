using System;
using System.Threading;

namespace ThreadSEW
{
    public class Counter
    {
        public static int index = 0;
        public static Semaphore semaphore = new Semaphore(1, 1);

        public static void Increment()
        {
            semaphore.WaitOne();
            index++;
            Console.WriteLine(index);
            semaphore.Release();
            Thread.Sleep(1);
        }
    }
}