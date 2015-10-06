using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clase_01_02_2013
{
    public partial class mayor : Form
    {
        public mayor()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(num1.Text);
            b = Convert.ToInt32(num2.Text);
            c = Convert.ToInt32(num3.Text);

            if (a > b) {
                if (a > c) {
                    resu.Text = a.ToString();
                }
            }
            else if (c > b)
            {
                resu.Text = c.ToString();
            }
            else
            {
                resu.Text = b.ToString();
            }
            
        }
    }
}
