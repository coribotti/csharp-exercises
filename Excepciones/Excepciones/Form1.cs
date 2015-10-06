using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                controlInventario();
            }
            catch (MiExcepcion me)
            {
                MessageBox.Show(me.Message);
            }
        }
        private void controlInventario()
        {
            if (true)
            {
                throw new MiExcepcion("Producto inválido");
            }
        }
    }
}
