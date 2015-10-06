using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class payments : Form
    {
        public payments()
        {
            InitializeComponent();
        }

        private void btnTot_Click(object sender, EventArgs e)
        {
            double total, extra;
            int hours;

            total = Convert.ToDouble(txtSalary.Text);
            hours= Convert.ToInt32(txtExtra.Text);

            if (cat1.Checked)
            {
                if (hours < 30)
                    extra = hours * 30;
                else
                    extra = 30 * 30;
                total += extra;
                txtTotal.Text = total.ToString();
            }
            else if (cat2.Checked)
            {
                if (hours < 30)
                    extra = hours * 38;
                else
                    extra = 30 * 38;
                total += extra;
                txtTotal.Text = total.ToString();
            }
            else if (cat3.Checked)
            {
                if (hours < 30)
                    extra = hours * 50;
                else
                    extra = 30 * 50;
                total += extra;
                txtTotal.Text = total.ToString();
            }
            else if (cat4.Checked)
            {
                if (hours < 30)
                    extra = hours * 70;
                else
                    extra = 30 * 70;
                total += extra;
                txtTotal.Text = total.ToString();
            }
            else
                txtTotal.Text = total.ToString();
        }
    }
}
