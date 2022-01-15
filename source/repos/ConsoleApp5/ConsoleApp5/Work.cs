using System;

namespace ConsoleApp5
{
    internal class Work
    {
        public int Data { get; internal set; }

        internal static void DoWork()
        {
            Console.WriteLine("Static Thread Procedure");

        }

        internal void DoMoreWork()
        {
            Console.WriteLine("Instance Thread procedure. Data={0}", Data);
        }
    }
}