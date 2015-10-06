using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataBases
{
    //Prrovider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Kurtz\\Documents\\DBTests.accdb
    public partial class Queries : Form
    {
        public Queries()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string Name, Age, AccNumb, Query;
            Name = txName.Text;
            Age = txAge.Text;
            AccNumb = txAccNumb.Text;
            Query = "INSERT INTO Alumnos (NumeroDeCuenta, Nombre, Edad) Values (@NumeroDeCuenta, @Nombre, @Edad)";
            
            using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Luis Rogelio\\Documents\\DBTests.accdb"))
            {
                try //Primero, trata de ejecutar este código.
                {
                    OleDbCommand cmd = new OleDbCommand(Query, con);    //Se crea el comando a partir de la consulta y la conexión al servidor.
                    cmd.Parameters.AddWithValue("@NumeroDeCuenta", AccNumb);    //Se le pasa el número de cuenta al parámetro @NumeroDeCuenta.
                    cmd.Parameters.AddWithValue("@Nombre", Name);   //Se le pasa el nombre al parámetro @Nombre.
                    cmd.Parameters.AddWithValue("@Edad", Age);  //Se le pasa la edad al parámetro @Edad.
                    con.Open();     //Se abre la conexión con el servidor.
                    cmd.ExecuteNonQuery();  //Se ejecuta el comando. No devuelve nada.
                    con.Close();    //Se cierra la conexión.
                    MessageBox.Show("Se ha ingresado el registro con éxito.", "Queries", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (OleDbException) //Ejecuta este código cuando hay una excepción (error).
                {
                    MessageBox.Show("Hubo un error en la conexión al servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
            }

        }
    }
}
