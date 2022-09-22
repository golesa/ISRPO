using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int a = 0;
        int b = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (textBox1.Top + textBox1.Height + 25 >= this.Height)
                {
                    textBox1.Top-=10;
                    a = 1;
                }
                else textBox1.Top+=10;
            }
            else {
                if (textBox1.Top <= 0)
                {
                    textBox1.Top+=10;
                    a = 0;
                }
                else textBox1.Top-=10;
            }

            if (b == 0)
            {
                if (textBox1.Left + textBox1.Width >= this.Width)
                {
                    textBox1.Left -= 10;
                    b = 1;
                }
                else textBox1.Left += 10;
            }
            else
            {
                if (textBox1.Left <= 0)
                {
                    textBox1.Left += 10;
                    b = 0;
                }
                else textBox1.Left -= 10;
            }


        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
    if (timer1.Enabled) timer1.Stop(); else timer1.Start();
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (timer1.Enabled) timer1.Stop(); else timer1.Start();
        }
    }
}
