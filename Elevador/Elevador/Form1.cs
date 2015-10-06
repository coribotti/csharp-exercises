using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Elevador elev= new Elevador();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            elev.irApiso(2);
            txtPiso.Text = elev.pisoActual.ToString();
            txtDoorStat.Text = "Cerrada";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            elev.irApiso(3);
            txtPiso.Text = elev.pisoActual.ToString();
            txtDoorStat.Text = "Cerrada";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            elev.irApiso(4);
            txtPiso.Text = elev.pisoActual.ToString();
            txtDoorStat.Text = "Cerrada";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            elev.irApiso(5);
            txtPiso.Text = elev.pisoActual.ToString();
            txtDoorStat.Text = "Cerrada";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            elev.irApiso(1);
            txtPiso.Text = elev.pisoActual.ToString();
            txtDoorStat.Text = "Cerrada";
        }

        private void btnPanic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El elevador se ha desplomado.", "Le dije que no me tocara...");
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            elev.abrirPuerta();
            txtDoorStat.Text = "Abierta";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            elev.cerrarPuerta();
            txtDoorStat.Text = "Cerrada";
        }
    }
}
