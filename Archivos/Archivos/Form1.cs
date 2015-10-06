using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Necesario para el manejo de archivos.

namespace Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(DateTime.Now.ToShortDateString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
//Muestra el cuadro de diálogo de guardado de archivos.
            saveFileDialog1.ShowDialog();
            int i = 65;
            long l = 65;
            double d = 3.14159878;
            string s = "Esta es una cadena";

            string texto = saveFileDialog1.FileName; //Guarda el nombre del archivo.

            saveFileDialog1.ShowDialog(); //Muestra el cuadro de diálogo.

            string binario = saveFileDialog1.FileName; //Se guarda nuevamente el nombre del archivo.

            FileStream ft = new FileStream(texto, FileMode.Create);
            FileStream fb = new FileStream(binario, FileMode.Create);
            StreamWriter wt = new StreamWriter(ft);
            BinaryWriter wb = new BinaryWriter(fb);
            wt.WriteLine(i);
            wt.WriteLine(l);
            wt.WriteLine(d);
            wt.WriteLine(s);

            wb.Write(i);
            wb.Write(l);
            wb.Write(d);
            wb.Write(s);

            wt.Close();
            wb.Close();

            ft.Close();
            fb.Close();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string FileName = openFileDialog1.FileName;
            FileStream ft = new FileStream(FileName, FileMode.Open);
            string FirstLine;
            StreamReader textReade = new StreamReader(ft);
            FirstLine=textReade.ReadLine();
            MessageBox.Show(FirstLine);
            txRead.Text = textReade.ReadToEnd();
            textReade.Close();
            ft.Close();
        }

        private void btnReadBinary_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            FileStream fb = new FileStream(fileName, FileMode.Open);
            int i;
            long l;
            double d;
            string s;
            BinaryReader binRead = new BinaryReader(fb);
            i = binRead.ReadInt32();
            l = binRead.ReadInt64();
            d = binRead.ReadDouble();
            s = binRead.ReadString();
            binRead.Close();
            fb.Close();            
        }
    }
}
