using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class window1 : Form
    {
        public window1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            double a, b, c, temp, res, res1;
            a = Convert.ToDouble(tx1.Text);
            b = Convert.ToDouble(tx2.Text);
            c = Convert.ToDouble(tx3.Text);
            temp= Math.Sqrt((Math.Pow(b,2)-(4*a*c)));
            if (temp >= 0)
            {
                res = (-b + temp) / 2 * a;
                tx4.Text = res.ToString();
                res1 = (-b - temp) / 2 * a;
                tx5.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Error: La raíz es negativa.");
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            window2 w2 = new window2();
            w2.Show();
        }

        private void tx1_Click(object sender, EventArgs e)
        {
            tx1.Text = "";
        }

        private void tx2_Click(object sender, EventArgs e)
        {
            tx2.Text = "";
        }

        private void tx3_Click(object sender, EventArgs e)
        {
            tx3.Text = "";
        }
    }
}
