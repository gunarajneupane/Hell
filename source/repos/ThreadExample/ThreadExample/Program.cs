using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample
{
    internal class Program
    {
        static int interval;

        static void Main(string[] args)
        {
            Console.Write("Interval to display results at?> ");
            interval = int.Parse(Console.ReadLine());
            Thread thisThread = Thread.CurrentThread;
            thisThread.Name = "Main Thread";
            ThreadStart workerStart = new ThreadStart(startMethod);
            Thread workerTHread = new Thread(workerStart);
            workerTHread.Start();
            DisplayNumbers();
            Console.WriteLine("Main Thread Finished");

            Console.ReadLine();
        }

        private static void startMethod()
        {
            DisplayNumbers();
            Console.WriteLine("Worker Thread Finished");
        }

        static void DisplayNumbers()
        {
            Thread thisThread = Thread.CurrentThread;
            string name = thisThread.Name;
            Console.WriteLine("String thread:" + name);
            Console.WriteLine(name + ": Current Culture=" + thisThread.CurrentCulture);
            for (int i = 1; i <= 8 * interval; i++)
            {
                if (i % interval == 0)
                {
                    Console.WriteLine(name + ": count has reached" + i);
                }
            }
        }

    }
}
