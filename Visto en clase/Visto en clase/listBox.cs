using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visto_en_clase
{
    public partial class listBox : Form
    {
        public listBox()
        {
            InitializeComponent();
        }
        int j = 1, k=0;
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (j <= 12)
            {
                listNumeros.Items.Add(txtNum.Text);
                txtNum.Text = "";
            }
            else
            {
                MessageBox.Show("Sólo se permiten 12 números en la lista.", "¡Aviso!");
            }
            j++;
        }
        int[] numeros = new int[12];
        private void btnPromedio_Click(object sender, EventArgs e)
        {
            int sumatoria=0, i, temp;
            Mymethods method = new Mymethods();
            for (i = 0; i < 12; i++)
            {
                sumatoria += Convert.ToInt32(listNumeros.Items[i]);
                numeros[i] = Convert.ToInt32(listNumeros.Items[i]);
            }
            txtProm.Text = method.promedio(sumatoria, 12).ToString();
        }

        private void btnMayorProm_Click(object sender, EventArgs e)
        {
            
            int[] mayores = new int[12];
            Mymethods method = new Mymethods();
            int sumatoria = 0, i, temp=0;
            for (i = 0; i < 12; i++)
            {
                sumatoria += Convert.ToInt32(listNumeros.Items[i]);
            }
            for (i = 0; i < 12; i++)
            {
                if (numeros[i] > method.promedio(sumatoria, 12))
                    mayores[i] = numeros[i];
                temp++;
            }
            for (i = 0; i < temp; i++)
            {
                if (mayores[i]>0)
                txtMayorProm.Text += mayores[i].ToString() + ",";
            }
        }

        private void btnNumMayor_Click(object sender, EventArgs e)
        {
            Mymethods method = new Mymethods();
            txtNumMayor.Text = method.numeroMayor(numeros, 12).ToString();
        }
    }
}
