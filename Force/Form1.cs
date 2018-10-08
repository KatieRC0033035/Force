using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Force
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 100.0));
        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 100.0));
        }

        double tan(double x)
        {
            return (Math.Tan(x * Math.PI / 100.0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double F = Convert.ToDouble(textBox1.Text);
                double a = Convert.ToDouble(textBox2.Text);
                double fx = F * cos(a);
                double fy = F * sin(a);
                label4.Text = "fx = " + fx;
                label3.Text = "fy = " + fy;
            }
            catch
            {
                label3.Text = "Fy =";
                label4.Text = "Fx =";
            }
        }
    }
}
