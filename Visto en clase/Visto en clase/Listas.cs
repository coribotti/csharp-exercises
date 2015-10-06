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
    public partial class Listas : Form
    {
        public Listas()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            list1.Items.Add(txtData.Text);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int cuantos, suma = 0, i;
            cuantos = list1.Items.Count;

            for (i = 0; i < cuantos; i++)
            {
                suma += Convert.ToInt32(list1.Items[i]);
                txtShow.Text += list1.Items[i] + " + ";
            }
            txtShow.Text += "0 = " + suma.ToString();
        }
    }
}
