using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple Threads");
            Printer p = new Printer();
            Thread[] Threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                Threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
                {
                    Name = "Child " + i
                };
            }
            foreach(Thread t in Threads)
                t.Start();
            Console.ReadLine();
        }
    }

    internal class Printer
    {
        internal void PrintNumbers()

        {
            Monitor.Enter(this);
            try
        
            for(int i=0; i<5; i++)
            {
                Thread.Sleep(100);
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }
        finally
            {
                Monitor.Exit(this);
            }
    }
}
