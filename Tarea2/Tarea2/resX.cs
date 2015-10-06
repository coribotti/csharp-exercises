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
    public partial class resX : Form
    {
        public resX()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double fx;
            int option,x;
            
            x = Convert.ToInt32(txtX.Text);
            option= x%4;

            switch (option)
            {
                case 0:
                    fx = Math.Pow(Convert.ToDouble(x), 2);
                    txtRes.Text = fx.ToString();
                    break;
                case 1:
                    fx = Convert.ToDouble(x)/6;
                    txtRes.Text = fx.ToString();
                    break;
                case 2:
                    fx = Math.Sqrt(Convert.ToDouble(x));
                    txtRes.Text = fx.ToString();
                    break;
                case 3:
                    fx = Math.Pow(Convert.ToDouble(x), 3) + 5;
                    txtRes.Text = fx.ToString();
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            payments window5 = new payments();
            window5.Show();
        }
    }
}
