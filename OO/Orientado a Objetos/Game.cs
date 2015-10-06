using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orientado_a_Objetos
{
    public partial class Game : Form
    {
        Tablero TheGame;
        Jugador J1, J2;
        public Game()
        {
            InitializeComponent();
            TheGame = new Tablero();
            J1 = new Jugador();
            J2 = new Jugador();
        }

        private void btnCasilla_Click(object sender, EventArgs e)
        {
            txtCasilla.Text = J1.casilla.ToString();
        }
    }
}
