using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars
{
    public partial class TheGame : Form
    {
        //Inicializa las variables necesarias.
        Covenant Elite; //Alien.fbf
        Spartan MasterChief; //Humano.
        int disparoAlien; //Guarda el daño inflingido por el Alien.
        int disparoSpartan; //Guarda el daño inflingido por el Humano.

        public TheGame()
        {
            InitializeComponent();
        }
        //Este temporizador se ejecuta cada 0.5 segundos.
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Cuando uno de los dos muera (vida=0), aparecerán ciertos pop-ups.
            if (Elite.vida == 0 || MasterChief.vida == 0)
            {
                timer1.Stop(); //Se detiene el temporizador.
                //Especifica quién ganó.
                if (MasterChief.vida == 0 && Elite.vida != 0)
                    MessageBox.Show("¡Gana " + Elite.name + "!", "Fin de la simulación", MessageBoxButtons.OK);
                else if (Elite.vida == 0 && MasterChief.vida != 0)
                    MessageBox.Show("¡Gana " + MasterChief.name + "!", "Fin de la simulación", MessageBoxButtons.OK);
                else
                    MessageBox.Show("¡Nadie gana!", "Fin de la simulación", MessageBoxButtons.OK);
                //Pregunta si se desea reiniciar la simulación.
                DialogResult chosen = MessageBox.Show("¿Desea iniciar la simulación de nuevo?", "" , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                //Reinicia la simulación
                if (chosen == DialogResult.Yes)
                {
                    Elite = new Covenant("Xe"); //Crea de nuevo al alien.
                    MasterChief = new Spartan("John"); //Crea de nevo al humano.
                    PBAliens.Value = Elite.vida; //Llena la barra de vida del alien.
                    labAliens.Text = "HP: " + Elite.vida.ToString(); //Coloca la cantidad de vida restante.
                    PBHumans.Value = MasterChief.vida; //Llena la barra de vida del humano.
                    labHumans.Text = "HP: " + MasterChief.vida.ToString(); //Coloca la cantidad de vida restante.
                    //Se limpian los registros de daño y se reinicia el temporizador.
                    txtAlien.Text = "";
                    txtHuman.Text = "";
                    timer1.Start();
                }
                //Pausa la simulación.
                else if (chosen == DialogResult.Cancel) 
                {
                    MessageBox.Show("La simulación se pausará.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnStart.Visible = true; //Reaparece el botón para iniciar la simulación, en caso de ser deseado.
                }
                //Cierra la simulación.
                else
                {
                    MessageBox.Show("La simulación se cerrará.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            //Si aún se encuentra con vida cualquiera de los dos, continúan disparándose.
            else
            {
                //Se guarda el daño inflingido.
                disparoSpartan=MasterChief.Dispara(); 
                disparoAlien=Elite.Dispara();
                //Se le resta la vida al alien.
                Elite.TakeDamage(disparoSpartan);
                PBAliens.Value = Elite.vida;
                labAliens.Text = "HP: " + Elite.vida.ToString();
                //Se le resta la vida al humano.
                MasterChief.TakeDamage(disparoAlien);
                PBHumans.Value = MasterChief.vida;
                labHumans.Text = "HP: " + MasterChief.vida.ToString();
                //Se añade el daño inflingido en los registros.
                txtAlien.Text += "Recibe " + disparoSpartan.ToString() + " de daño.\r\n";
                txtHuman.Text += "Recibe " + disparoAlien.ToString() + " de daño.\r\n";
            }
        }

        private void txtStart_Click(object sender, EventArgs e)
        {
            //Se crean un alien y un humano para la batalla.
            Elite = new Covenant("Xe");
            MasterChief = new Spartan("John");
            //Se asignan y aparecen los nombres de los participantes.
            labAlienName.Text = Elite.name;
            labAlienName.Visible = true;
            labHumanName.Text = MasterChief.name;
            labHumanName.Visible = true;
            //Se llenan las barras de vida y se hacen visibles.
            PBAliens.Value = Elite.vida;
            PBAliens.Visible = true;
            PBHumans.Value = MasterChief.vida;
            PBHumans.Visible = true;
            //Se limpian y aparecen los registros.
            txtAlien.Text = "";
            gbAliens.Visible = true;
            txtHuman.Text = "";
            gbHumans.Visible = true;
            //Aparecen las cantidades de vida restante.
            labAliens.Text = "HP: " + Elite.vida.ToString();
            labAliens.Visible = true;
            labHumans.Text = "HP: " + MasterChief.vida.ToString();
            labHumans.Visible = true;
            //El botón de inicio desaparece.
            btnStart.Visible = false;
            //Inicia el temporizador.
            timer1.Start();
        }
    }
}
