using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double t, y, z;
            t = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = (2 * t + y * Math.Cos(t)) / (Math.Sqrt(y + 4.831));

            listBox1.Items.Add(" t=" + t);
            listBox1.Items.Add(" y=" + y);
            listBox1.Items.Add(" z=" + z);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double y, n, d;
            y = Convert.ToDouble(textBox3.Text);
            n = Convert.ToDouble(textBox4.Text);
            d = (Math.Pow(y, 2) + 0.5 * n + 4.8) / Math.Sin(y);

            listBox2.Items.Add("y=" + y);
            listBox2.Items.Add("n=" + n);
            listBox2.Items.Add("d=" + d);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            double t, y, r, n;
            t = Convert.ToDouble(textBox5.Text);
            y = Convert.ToDouble(textBox6.Text);
            n = Convert.ToDouble(textBox7.Text);
            r = (Math.Sin(Math.Pow(2 * t + 1, 2)) + 0.3) /( 1 * n * (t + y));

            listBox3.Items.Add("t=" + t);
            listBox3.Items.Add("y=" + y);
            listBox3.Items.Add("n=" + n);
            listBox3.Items.Add("r=" + r);
        }
    }
}
