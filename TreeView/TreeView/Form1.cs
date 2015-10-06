using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        //Objetos a usar.
        Alumno Hello;
        Hashtable contAlumnos;
        public Form1()
        {
            InitializeComponent();
            //Se inicializa la tabla donde se almacenarán los datos de los alumnos.
            contAlumnos = new Hashtable();
        }

        private void btnNewAlumno_Click(object sender, EventArgs e)
        {
            txName.Text = "";
            txnumCuenta.Text = "";
            txProm.Text = "";
            cbGroup.Text = "";
            gBAlumno.Visible = true;
            btnNewAlumno.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hello = new Alumno(txnumCuenta.Text,txName.Text, cbGroup.SelectedItem + "",Convert.ToDouble(txProm.Text));
            tvShow.Nodes[cbGroup.SelectedItem.ToString()].Nodes.Add(Hello.NumCuenta +"", Hello.ToString());
            contAlumnos.Add(Hello.NumCuenta, Hello);
            gBAlumno.Visible = false;
            btnNewAlumno.Visible = true;
        }

        private void tvShow_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {            
            string Key = e.Node.Name;            
            Hello = (Alumno)contAlumnos[Key];
            gBAlumno.Visible = true;
            txName.Text = Hello.Nombre;
            txnumCuenta.Text = Hello.NumCuenta;
            txProm.Text = Hello.Promedio + "";
            cbGroup.Text = Hello.Grupo;        
        }
    }
}
