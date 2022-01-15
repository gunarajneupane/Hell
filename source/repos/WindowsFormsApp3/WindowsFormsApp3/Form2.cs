using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(textBox1.Text);
                double p = double.Parse(textBox2.Text);
                Int32 result =
                    Int32.Parse(textBox1.Text) / Int32.Parse(textBox2.Text);
                //d = Math.Pow(d,p);
                //Label1.Text = d.ToString();
                //    Label2.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                label1.Text = "Error in number format"+ex;
            }
            catch (DivideByZeroException ex)
            {
                label1.Text = "Divide by zero exception"+ex;
            }
        }
    }
}
