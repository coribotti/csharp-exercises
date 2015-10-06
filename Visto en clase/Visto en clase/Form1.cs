using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visto_en_clase
{
    public partial class mainWin : Form
    {
        public mainWin()
        {
            InitializeComponent();
        }

        private void btnNewPer_Click(object sender, EventArgs e)
        {
            winPerfect win2 = new winPerfect();
            win2.Show();
        }

        private void btnNewList_Click(object sender, EventArgs e)
        {
            Listas window3 = new Listas();
            window3.Show();
        }

        private void btnNewConstante_Click(object sender, EventArgs e)
        {
            mathConst window4 = new mathConst();
            window4.Show();
        }

        private void btnNewEuler_Click(object sender, EventArgs e)
        {
            windowEuler window5 = new windowEuler();
            window5.Show();
        }

        private void btnNewListas_Click(object sender, EventArgs e)
        {
            listBox window6 = new listBox();
            window6.Show();
        }
    }
}
