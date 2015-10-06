using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHisto_Click(object sender, EventArgs e)
        {
            int n, i;
            txtShow.Text = "";
            txtShow.TextAlign = HorizontalAlignment.Left;
            n = Convert.ToInt32(txtValue.Text);
            for (i = 1; i <= n; i++)
            {
                txtShow.Text += "*";
            }
        }

        private void btnTria1_Click(object sender, EventArgs e)
        {
            int n, i;
            string text="";
            txtShow.Text="";
            txtShow.TextAlign = HorizontalAlignment.Left;
            n = Convert.ToInt32(txtValue.Text);
            for (i = 1; i <= n; i++)
            {
                text += "*";
                txtShow.Text += text + "\r\n";
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            int n, i;
            string text = "";
            txtShow.Text = "";
            txtShow.TextAlign = HorizontalAlignment.Left;
            n = Convert.ToInt32(txtValue.Text);
            for (i = 1; i <= n; i++)
                text += "*";
            for (i = 1; i <= n; i++)
                txtShow.Text += text+"\r\n";
        }

        private void btnTria2_Click(object sender, EventArgs e)
        {
            int n, i;
            string text = "";
            txtShow.Text = "";
            txtShow.TextAlign = HorizontalAlignment.Right;
            n = Convert.ToInt32(txtValue.Text);
            for (i = 1; i <= n; i++)
            {
                text += "*";
                txtShow.Text += text + "\r\n";
            }
        }

        private void btnSerie_Click(object sender, EventArgs e)
        {
            int n;
            double res=0, i;
            bool sign = true;
            txtShow.Text = "";
            txtShow.TextAlign = HorizontalAlignment.Left;
            n = Convert.ToInt32(txtValue.Text);
            for (i = 1; i <= n; i += 2)
            {
                if (sign == false)
                {
                    res -= (4 / i);
                }
                if (sign == true)
                {
                    res += (4 / i);
                }
                sign = !sign;
            }
            txtShow.Text = res.ToString();
        }
        /*
         * Desplegar una tabla en una caja de texto para solucionar la
        siguiente ecuación para x:
        3x – 5y + 2 = 35
         variando los valores de y entre -5 y +5
        y= (33-3x)/-5
         */
        private void btnEcu_Click(object sender, EventArgs e)
        {
            
            double x, y; //x son la cantidad de iteraciones. y es el resultado de la ecuación
            txtShow.TextAlign = HorizontalAlignment.Left;
            txtShow.Text = "x\r\t y \r\n";

            for (x = -5; x <= 5; x++)
            {
                y = (33 - 3 * x) / -5;
                txtShow.Text += x.ToString() + "\r\t" + y.ToString() + "\r\n";
            }
        }
    }
}
