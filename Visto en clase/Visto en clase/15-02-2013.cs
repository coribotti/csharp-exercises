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
    public partial class winPerfect : Form
    {
        public bool esPerfecto(int numero)
        {
            int i, divisores=0;

            for (i = 1; i < (numero/2); i++)
            {
                if (numero % i == 0)
                {
                    divisores += i;
                }
            }
            if (divisores == numero)
                return true;
            else
                return false;
        }
        public winPerfect()
        {
            InitializeComponent();
        }

        private void btnAnalize_Click(object sender, EventArgs e)
        {
            if (esPerfecto(Convert.ToInt32(txtN.Text)) == true)
                txtRes.Text = "Si es Perfecto";
            else
                txtRes.Text = "No es Perfecto";
        }
    }
}
