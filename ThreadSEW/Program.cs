using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadSEW
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Thread t1 = new Thread(()=>Worker.Work1());
            Thread t2 = new Thread(()=>Worker.Work2());

            t1.Start();
            t2.Start();*/

            List<Thread> threads = new List<Thread>();

            for (int i = 0; i < 100; i++)
            {
                Thread t = new Thread(() => Counter.Increment());
                threads.Add(t);
            }

            threads.ForEach(t=>t.Start());
        }
    }
}