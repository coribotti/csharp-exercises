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
    public partial class equation : Form
    {
        public equation()
        {
            InitializeComponent();
        }
        /*
            y = x2 + 2x – 3  sí  	-3 <= x <= 2     
            y = 5x + 7       sí  	 2 < x <= 10 
            y = 0            sí  	 x <= -3 ó x > 10  
        */
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int x;
            double y;
            x = Convert.ToInt32(txtX.Text);

            if (x >= -3 && x <= 2)
            {
                y = Math.Pow(x, 2) + 2 * x - 3;
                txtY.Text = y.ToString();
            }
            else if (x > 2 && x <= 10)
            {
                y = 5 * x + 7;
                txtY.Text = y.ToString();
            }
            else
                txtY.Text = "0";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            resX window4 = new resX();
            window4.Show();
        }
    }
}
