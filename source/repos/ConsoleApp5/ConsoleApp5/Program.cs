using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadStart threadDelegate = new ThreadStart(Work.DoWork);
            Thread newThread = new Thread(threadDelegate);
            newThread.Start();

            Work w = new Work();
            w.Data = 42;
            threadDelegate = new ThreadStart(w.DoMoreWork);
            newThread = new Thread(threadDelegate);
            newThread.Start();
            Console.ReadLine();
        }

        

        
    }
}
