using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Thread newThread;

        bool flag = false, running = false;
        public Form1()
        {
            InitializeComponent();
            newThread = new System.Threading.Thread;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             void button1_Click(object sender, EventArgs e)
            {
                running = !running;
                //yikes!! newThread.Abort();


            }
        }
    }
}
