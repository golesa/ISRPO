using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool IsSimple(int a)
        {
            if (a == 0) return false;
            else if (a < 3) return true;
            for (int i = 2; i < a; i++)
            {
                if (Math.Abs(a / i) == 0) return false; 
                else return true;
            }
        }
    }
}
