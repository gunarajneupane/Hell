using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    internal class Program
    {
        public void go()
        {
            Console.WriteLine("in go");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Starting....");
            Program app = new Program();
            app.go();
            MessageBox.Show("Danger..", "Alert!",
         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Console.WriteLine("Enter a number:");
            int val = Convert.ToInt32(Console.ReadLine());
            int square = val + val;
            Console.WriteLine("square:" + square);
            Console.Read();
        }
    }
}
