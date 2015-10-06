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
    public partial class windowEuler : Form
    {
        public windowEuler()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int numero, potencia;
            Mymethods euler = new Mymethods();
            numero = Convert.ToInt32(txtX.Text);
            potencia = Convert.ToInt32(txtY.Text);
            txtRes.Text = euler.euler(numero, potencia).ToString(); ;
        }
    }
}
