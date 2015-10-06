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
    public partial class window2 : Form
    {
        public window2()
        {
            InitializeComponent();
        }

        private void tx1_Click(object sender, EventArgs e)
        {
            tx1.Text = "";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int sal;
            double res;
            sal = Convert.ToInt32(tx1.Text);
            if (sal <= 1000)
            {
                res = sal * 1.15;
                tx2.Text = res.ToString();
            }
            else if (sal > 1000 && sal <= 2000)
            {
                res = sal * 1.12;
                tx2.Text = res.ToString();
            }
            else if (sal > 2000 && sal <= 3000)
            {
                res = sal * 1.11;
                tx2.Text = res.ToString();
            }
            else if (sal > 3000 && sal <= 4000)
            {
                res = sal * 1.1;
                tx2.Text = res.ToString();
            }
            else
            {
                res = sal * 1.08;
                tx2.Text = res.ToString();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            window3 w3 = new window3();
            w3.Show();
        }

        private void tx1_Enter(object sender, EventArgs e)
        {
            tx1.Text = "";
        }
    }
}
