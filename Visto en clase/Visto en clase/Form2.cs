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
    public partial class mathConst : Form
    {
        public mathConst()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            Mymethods cons = new Mymethods();
            int numero;
            numero = Convert.ToInt32(txtNumero.Text);
            txtRes.Text = cons.constante(numero).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mymethods metodo = new Mymethods();
            if (metodo.Primo(Convert.ToInt32(txtNumero.Text)) == true)
                MessageBox.Show("Es un número primo", "¡Aviso!");
            else
                MessageBox.Show("No es un número primo", "¡Aviso!");
        }
    }
}
