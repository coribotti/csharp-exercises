using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puntos
{
    public partial class Form1 : Form
    {
        ArrayList Puntos;
        double Sumatoria = 0;
        Punto p;
        int cuantos, i=0;
        public Form1()
        {
            InitializeComponent();
            Puntos = new ArrayList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Puntos.Add(new Punto(Convert.ToInt32(txValueX.Text), Convert.ToInt32(txValueY.Text)));
        }
        
        private void btnTotal_Click(object sender, EventArgs e)
        {
            cuantos = Puntos.Count;
            p = (Punto)Puntos[0];
            Punto p2;
            for (i = 1; i < cuantos; i++)
            {
                p2 = (Punto)Puntos[i];
                Sumatoria += p2.Distancia(p.x, p.y);
                p = p2;
            }
            txTotal.Text = Sumatoria + "";
        }
    }
}
