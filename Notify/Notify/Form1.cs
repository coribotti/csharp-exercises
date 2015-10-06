using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notify
{
    public partial class Form1 : Form
    {
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            Tmr.Start();
            c = 0;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            c++;
            if (c == 10)
            {
                Tmr.Stop();
                Notif.ShowBalloonTip(1200);
            }
        }
    }
}
