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
    public partial class shop : Form
    {
        public shop()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double charge;
            double price;
            price = Convert.ToDouble(txPrice.Text);

            if (price >= 500 && price <= 1000)
            {
                price *= 0.95;
                txCharge.Text = price.ToString();
            }
            else if (price > 1000 && price <= 7000)
            {
                price *= 0.89;
                txCharge.Text = price.ToString();
            }
            else if (price > 7000 && price <= 15000)
            {
                price *= 0.82;
                txCharge.Text = price.ToString();
            }
            else if (price > 15000)
            {
                price *= 0.75;
                txCharge.Text = price.ToString();
            }
            else
                txCharge.Text = price.ToString();

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            
            double pay, ret, charge;
            string miss;

            pay = Convert.ToDouble(txPay.Text);
            charge = Convert.ToDouble(txCharge.Text);

            ret = pay - charge;
            if (ret > 0)
                txRet.Text = ret.ToString();
            else
            {
                
                miss = Math.Abs(ret).ToString();
                MessageBox.Show("Le hace falta: $"+miss, "No sea tranza");
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            equation window3 = new equation();
            window3.Show();
        }
    }
}
