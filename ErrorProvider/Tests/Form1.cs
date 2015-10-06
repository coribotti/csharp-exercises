using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txName.Text.Length > 2)
            {
                Error.SetError(txName, "Longitud no válida");
            }
            if (!txEmail.Text.Contains('@'))
            {
                Error.SetError(txEmail, "Correo inválido");
            }
        }

        private void txName_TextChanged(object sender, EventArgs e)
        {
            Error.SetError(txName, "");
        }

        private void txEmail_TextChanged(object sender, EventArgs e)
        {
            Error.SetError(txEmail, "");
            
        }
    }
}
