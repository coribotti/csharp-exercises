using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_12_02_2013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtRes.Text=sumar(Convert.ToInt32(txtNum1.Text),Convert.ToInt32(txtNum2.Text)).ToString();
        }
        private int sumar(int op1, int op2)
        {
            int res;
            res = op1 + op2;
            return res;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOps.Items.Add("Suma");
            cmbOps.Items.Add("Resta");
            cmbOps.Items.Add("Multiplicación");
            cmbOps.Items.Add("Residuo");
            cmbOps.SelectedIndex = 0;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int op1, op2;
            int r;
            op1 = Convert.ToInt32(txtNum1.Text);
            op2 = Convert.ToInt32(txtNum2.Text);

            switch (cmbOps.SelectedIndex)
            {
                case 0:
                    txtRes.Text = sumar(op1, op2).ToString();
                    break;
                case 1:
                    txtRes.Text = (op1 - op2).ToString();
                    break;
                case 2:
                    txtRes.Text = (op1 * op2).ToString();
                    break;
                case 3:
                    txtRes.Text = (op1 % op2).ToString();
                    break;
            }
        }
    }
}
