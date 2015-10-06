using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serpientes_y_escaleras
{
    public partial class SerpientesEscaleras : Form
    {
        //Crea a los jugadores, el tablero y el dado.
        Jugador J1= new Jugador(); 
        Jugador J2= new Jugador();
        Tablero Game= new Tablero();
        Dado D1= new Dado();
        //Se crean las fichas que se usarán en el tablero.
        Label LJ1 = new Label();
        Label LJ2 = new Label();
        //Variables: 
        //resDado guarda el numero obtenido en el dado.
        //bandera indica si ha acabado o no el juego.
        //linea es la cantidad de pixeles que se necesitan para que las fichas avancen una casilla.
        //casillaAMoverse Indica a qué posición deberá moverse la ficha.
        //turno indica a quién le toca tirar el dado.
        int resDado, bandera =1, linea=47, casillaAMoverse;
        bool turno= true;

        public SerpientesEscaleras()
        {
            InitializeComponent();
            //Crea y añade las fichas al juego.
            LJ1.BackColor = Color.PowderBlue;
            LJ1.Height = 20;
            LJ1.Width = 20;
            LJ1.Location = new Point(0, 281);
            LJ1.Text = "J1";
            LJ1.TextAlign = ContentAlignment.MiddleCenter;
            LJ2.BackColor = Color.DarkRed;
            LJ2.Height = 20;
            LJ2.Width = 20;
            LJ2.Location = new Point(0, 281);
            LJ2.Text = "J2";
            LJ2.TextAlign = ContentAlignment.MiddleCenter;
            picBTablero.Controls.Add(LJ1);
            picBTablero.Controls.Add(LJ2);
        }

        private void btnDado1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                //Si es su turno y aún no acaba el juego, entra.
                if (turno == true && bandera != 0)
                {
                    turno = !turno;
                    resDado = J1.Lanzar(D1); //Se guarda el valor del dado.
                    txtDado.Text = resDado.ToString(); //Se añade el valor obtenido del dado al formulario.
                    casillaAMoverse = J1.Avanzar(Game.QueHay(J1.casilla)); //Se guarda la casilla a la cual se moverá.
                    //Si la casilla a la que se moverá está entre las primeras 5, entra.
                    if (casillaAMoverse <= 5 && casillaAMoverse != 0)
                    {
                        LJ1.Left = (linea * casillaAMoverse); //Se mueve la ficha a la posición correspondiente.
                    }
                    //Siguientes 5 casillas.
                    else if (casillaAMoverse <= 10 && casillaAMoverse != 0)
                    {
                        LJ1.Left = 305 - (linea * (casillaAMoverse - 5));
                        LJ1.Top = 215;
                    }
                    //Siguientes 5 casillas.
                    else if (casillaAMoverse <= 15 && casillaAMoverse != 0)
                    {
                        LJ1.Left = (linea * (casillaAMoverse - 10));
                        LJ1.Top = 147;
                    }
                    //Siguientes 5 casillas.
                    else if (casillaAMoverse <= 20 && casillaAMoverse != 0)
                    {
                        LJ1.Left = (linea * (casillaAMoverse - 15)) + 23;
                        LJ1.Top = 81;
                    }
                    //Siguientes 5 casillas.
                    else if (casillaAMoverse <= 25 && casillaAMoverse != 0)
                    {
                        LJ1.Left = (linea * (casillaAMoverse - 20));
                        LJ1.Top = 13;
                    }
                    //Si se indica que la casillaAMoverse es 0, el juego termina.
                    else
                    {
                        bandera = casillaAMoverse; //Mueve la bandera a 0 para terminar el juego.
                        //Se manda la ficha a la última casilla.
                        LJ1.Left = linea * 5;
                        LJ1.Top = 13;
                        //Muestra posteriormente la casilla actual en el formulario.
                        casillaAMoverse = 25;
                        //Avisa que el juego a terminado, quién es el ganador y si se desea salir de la aplicación..
                        MessageBox.Show("Gana el jugador 1", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult Pregunta = MessageBox.Show("¿Desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Pregunta == DialogResult.Yes)
                            this.Close();
                    }
                    txCasillaJ1.Text = casillaAMoverse.ToString();
                }
                //Si aún no termina el juego y no es su turno, avisa que el turno es del otro jugador.
                else if (turno == false && bandera != 0)
                {
                    MessageBox.Show("Le toca al Jugador 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (e.KeyCode == Keys.P)
            {
                if (turno == false && bandera != 0)
                {
                    turno = !turno;
                    resDado = J2.Lanzar(D1);
                    txtDado.Text = resDado.ToString();
                    casillaAMoverse = J2.Avanzar(Game.QueHay(J2.casilla));
                    if (casillaAMoverse <= 5 && casillaAMoverse != 0)
                    {
                        LJ2.Left = (linea * casillaAMoverse);
                    }
                    else if (casillaAMoverse <= 10 && casillaAMoverse != 0)
                    {
                        LJ2.Left = 305 - (linea * (casillaAMoverse - 5));
                        LJ2.Top = 215;
                    }
                    else if (casillaAMoverse <= 15 && casillaAMoverse != 0)
                    {
                        LJ2.Left = (linea * (casillaAMoverse - 10));
                        LJ2.Top = 147;
                    }
                    else if (casillaAMoverse <= 20 && casillaAMoverse != 0)
                    {
                        LJ2.Left = (linea * (casillaAMoverse - 15)) + 23;
                        LJ2.Top = 81;
                    }
                    else if (casillaAMoverse <= 25 && casillaAMoverse != 0)
                    {
                        LJ2.Left = (linea * (casillaAMoverse - 20));
                        LJ2.Top = 13;
                    }
                    else
                    {
                        bandera = casillaAMoverse;
                        LJ2.Left = linea * 5;
                        LJ2.Top = 13;
                        casillaAMoverse = 25;
                        MessageBox.Show("Fin del juego.", "Gana el jugador 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult Pregunta = MessageBox.Show("¿Desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Pregunta == DialogResult.Yes)
                            this.Close();
                    }
                    txtCasillaJ2.Text = casillaAMoverse.ToString();
                }

                else if (turno == true && bandera != 0)
                {
                    MessageBox.Show("Le toca al Jugador 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                //Cierra la aplicación.
            else if (e.KeyCode == Keys.X)
            {
                this.Close();
            }
        }

        private void SerpientesEscaleras_Load(object sender, EventArgs e)
        {

        }
    }
}
