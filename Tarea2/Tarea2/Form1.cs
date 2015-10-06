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
    public partial class trains : Form
    {
        public trains()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            double dist, price;
            int days;
            
            dist = Convert.ToDouble(txDist.Text);
            days = Convert.ToInt32(txDays.Text);
            dist *= 2;
            if (dist > 800 && days > 7)
            {
                price = (dist * 0.17)*0.7;
                txPrice.Text = price.ToString();
                MessageBox.Show("Usted obtiene un descuento del 30%");
            }
            else
            {
                price = (dist * 0.17);
                txPrice.Text = price.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            shop window = new shop();
            window.Show();
        }
    }
}
