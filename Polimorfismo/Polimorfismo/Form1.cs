using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b;
            b = (Button)sender;
            b.BackColor = Color.Aqua;
            MessageBox.Show("Fue el " + b.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            Button b;
            b = (Button) this.Controls.Find("button" + n.ToString(), false)[0];
            b.Text = "Aquí";
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Red;
        }

        private void otroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox2.ForeColor = colorDialog1.Color;
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox2.Font = fontDialog1.Font;
        }
    }
}
