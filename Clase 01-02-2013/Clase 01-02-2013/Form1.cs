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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnpuls_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(Numero1.Text);
            b = Convert.ToInt32(Numero2.Text);
            c = a + b;
            Resultado.Text = c.ToString();
            if (c > 20)
            {
                MessageBox.Show("El numero es muy grande");
            }
        }

        private void Numero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            mayor w2 = new mayor();
            w2.Show();
        }
    }
}
