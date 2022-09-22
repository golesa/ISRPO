using System;
using System.Windows.Forms;

namespace Lr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            a();
        }
        public void a()
        {
            tbRow.ContextMenu = new ContextMenu();
            tbRes.ContextMenu = new ContextMenu();

            nudX.DecimalPlaces = 2;
            nudX.Increment = 0.01M;
            nudX.Maximum = 0.99M;
            nudX.Minimum = -1;
            nudX.Value = 0;

            nudEps.DecimalPlaces = 7;
            nudEps.Increment = 0.0000001M;
            nudEps.Maximum = 0.9800000M;//1.0M;
            nudEps.Minimum = 0.0000001M;
            nudEps.Value = 0.0000001M;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = 2;

            double x = (double)nudX.Value;
            double eps = (double)nudEps.Value;

            double currentValue=x;
            double amount = x;
            double temp = x;

            while (eps <= Math.Abs(currentValue))
            {
                currentValue = temp * (((n - 1) * x) / n);
                temp = currentValue;
                amount += currentValue;
                n++;
            }

            amount = 0 - amount;
            double Res = Math.Log(1 - x);
            
            tbRow.Text = amount.ToString("0.0000000");
            tbCount.Text = n.ToString();
            tbRes.Text = Res.ToString("0.0000000");
        }

        private void tbRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}