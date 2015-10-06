using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class window3 : Form
    {
        public window3()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            char calif;
            calif = Convert.ToChar(tx1.Text);
                //if (calif=='a' || calif=='A') {
                //    tx2.Text = "10";
                //}
                //else if (calif=='b' || calif=='B') {
                //    tx2.Text = "9";
                //}
                //else if (calif=='c' || calif=='C') {
                //    tx2.Text = "8";
                //}
                //else if (calif=='d' || calif=='D') {
                //    tx2.Text = "7";
                //}
                //else if (calif=='e' || calif=='E') {
                //    tx2.Text = "6";
                //}
                //else if (calif=='f' || calif=='F') {
                //    tx2.Text = "5";
                //}
                //else {
                //    MessageBox.Show("Ingrese una calificación válida (A-F).");
                //}
            switch (calif)
            {
                case 'a': 
                case 'A':
                    tx2.Text = "10";
                    break;
                case 'b':
                case 'B':
                    tx2.Text="9";
                    break;
                case 'c':
                case 'C':
                    tx2.Text = "8";
                    break;
                case 'd':
                case 'D':
                    tx2.Text = "7";
                    break;
                case 'e':
                case 'E':
                    tx2.Text = "6";
                    break;
                case 'f':
                case 'F':
                    tx2.Text = "6";
                    break;
                default:
                    MessageBox.Show("Ingrese una letra del rango válido (A-F)");
                    break;
            }
        }
    }
}
