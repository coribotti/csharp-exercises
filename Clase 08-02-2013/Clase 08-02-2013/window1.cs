using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_08_02_2013
{
    public partial class window1 : Form
    {
        public window1()
        {
            InitializeComponent();
        }

        private void window1_Load(object sender, EventArgs e)
        {

        }

        private void btnCyc_Click(object sender, EventArgs e)
        {
            int i, num, res;
            num = Convert.ToInt32(txtNum.Text);

            for (i = 1; i <= 12; i++)
            {
                res = num * i;
                txtData.Text += num.ToString() + " x " + i.ToString() + " = " + res.ToString()+"\r\n";
            }
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            int i, temp=1, num;
            num = Convert.ToInt32(txtNum.Text);
            for (i = 1; i <= num; i++)
            {
                temp *= i;
                txtData.Text = temp.ToString();
            }
        }
    }
}
