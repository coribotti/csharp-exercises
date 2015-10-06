using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimExam
{
    public partial class Form1 : Form
    {
        //Cadena de conexión para la base de datos.
        string CadCon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\pak2.accdb";
        OleDbDataReader DR;
        OleDbConnection Con;
        OleDbCommand cmd;
        string consulta;
        ArrayList QueMov;

        public Form1()
        {
            InitializeComponent();
            //Se inicia la conexión y se crea un ArrayList
            Con = new OleDbConnection(CadCon);
            QueMov = new ArrayList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string consulta= "SELECT Nombre from Clientes";
            //Crea comando.
            cmd = new OleDbCommand(consulta, Con);
            Con.Open(); //Abre conexión
            DR = cmd.ExecuteReader();   //Ejecuta datareader

            while (DR.Read())   //Mientras tenga datos por leer
            {
                cmbClientes.Items.Add(DR.GetValue(0));  //Añado los nombres al combobox
            }

            Con.Close();    //Cierra conexión
            //Nueva consulta
            consulta = "SELECT descripcion FROM CatalogoMovimientos";
            //Crea comando
            cmd = new OleDbCommand(consulta, Con);

            Con.Open();     //Abre conexión
            DR = cmd.ExecuteReader();   //Ejecutar datareader

            while (DR.Read())   //Mientras sigan datos por leer
                QueMov.Add(DR.GetValue(0)); //Se añaden las descripciones de los movimientos

            Con.Close();    //Cierra conexión
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPaquetes.Items.Clear();  //Limpia el combobox de paquetes
            //Consulta sql
            consulta = "SELECT Numero FROM Paquetes WHERE Cliente = " + (cmbClientes.SelectedIndex +1);
            //Se crea el comando
            cmd = new OleDbCommand(consulta, Con);
            Con.Open();     //Abre conexión
            DR = cmd.ExecuteReader();   //Ejectura datareader

            while (DR.Read())   //Mientras siga leyendo
                cmbPaquetes.Items.Add(DR.GetValue(0));  //Añado al combobox los datos de la columna que saque de la base de datos
            Con.Close();    //Cierra conexión
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();   //Se muestra el cuadro de diálogo para guardar
            string nombreArchivo = saveFileDialog1.FileName;    //Contiene la ruta completa del archivo a guardar

            FileStream Holi = new FileStream(nombreArchivo,FileMode.Create);
            StreamWriter writer = new StreamWriter(Holi);

            consulta = "SELECT * FROM Paquetes WHERE Numero = " + cmbPaquetes.SelectedItem;
            cmd = new OleDbCommand(consulta, Con);

            Con.Open();
            DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                writer.Write("Nº: " + DR.GetValue(0) + "\t");   //Escribe el número de paquete
                writer.Write("Costo: $" + DR.GetValue(2) + "\t");   //Escribe el costo
                writer.Write("Origen: " + DR.GetValue(3) + "\t");   //Escribe el origen
                writer.WriteLine("Destino: " + DR.GetValue(4)); //Escribe el destino
            }
            Con.Close();

            consulta = "SELECT * FROM Movimientos WHERE Paquete = " + cmbPaquetes.SelectedItem;

            cmd = new OleDbCommand(consulta, Con);
            Con.Open();
            DR = cmd.ExecuteReader();
            int mov;
            while (DR.Read())
            {
                writer.Write("Fecha: " + DR.GetValue(2) + "\t");    //Añade la fecha
                mov = (int)DR.GetValue(3);
                writer.WriteLine(QueMov[mov-1]);    //Añade el movimiento
            }
            Con.Close();    //Cierra conexión
            writer.Close(); //Cierra Streamwriter
            Holi.Close();   //Ciera filestream
            //PINCHE IMBÉCIL!!!! .l. (-_-) .l.
        }
    }
}
