using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuenta
{
    public partial class Cuentas : Form
    {
        Cuenta Acc;
        public Cuentas()
        {
            InitializeComponent();
        }
        //Se utiliza para determinar si se está trabajando con una cuenta o no.
        bool account = false;

        private void btnTest_Click(object sender, EventArgs e)
        {
            Cuenta c1 = new Cuenta(100);
            Cuenta c2 = new Cuenta();
            c1.Deposito(100);
            c2.Deposito(100);
            c1.Retiro(150);
            c2.Retiro(150);
            MessageBox.Show(c1.ToString() + " " + c1.saldo.ToString() + " " + c1.numero.ToString());
            MessageBox.Show(c2.ToString() + " " + c2.saldo.ToString() + " " + c2.numero.ToString());
        }

        //Crea un label que se usará dentro del programa.
        Label cuant = new Label();
        protected void btnNew_Click(object sender, EventArgs e)
        {
            //Muestra un cuadro de diálogo con opciones: Sí/No
            DialogResult resultado = MessageBox.Show("¿Desea iniciar la cuenta con saldo?", "Aviso", MessageBoxButtons.YesNo);
            //Si es clickeado Sí, aparecen: un textbox, botón y el label creado anteriormente.
            if (resultado == DialogResult.Yes)
            {
                cuant.Text = "¿Cuánto? $";
                cuant.Left = 9;
                cuant.Top = 130;
                this.Controls.Add(cuant);
                txtCant.Visible = true;
                btnCrea.Visible = true;
            }
            //Se manda a llamar la función crearCuenta.
            else
            {
                crearCuenta(false);
                //Avisa que la cuenta se ha creado.
                MessageBox.Show("Su cuenta se ha creado exitosamente", "Aviso", MessageBoxButtons.OK);
            }
        }

        //Agrega el saldo a la cuenta creada (llamada a la función crearCuenta).
        protected void btnCrea_Click(object sender, EventArgs e)
        {
            crearCuenta(true);
            //Avisa que la cuenta se ha creado.
            MessageBox.Show("Su cuenta se ha creado exitosamente", "Aviso", MessageBoxButtons.OK);
            btnCrea.Visible = false;
            cuant.Visible = false;
            txtCant.Visible = false;
            account = true;
        }
        /// <summary>
        /// Crea una cuenta nueva.
        /// </summary>
        /// <param name="saldo">
        /// Recibe un valor booleano que especifica si recibirá saldo o no.
        /// </param>
        /// 
        void crearCuenta(bool saldo)
        {
            //Si recibe un valor True, crea una cuenta con el saldo especificado en el textbox.
            if (saldo == true)
            {
                 Acc = new Cuenta(Convert.ToDouble(txtCant.Text));
            }
            //Si recibe un valor False, crea una cuenta estándar (sin saldo).
            else
            {
                 Acc = new Cuenta();
            }
            account = true;
        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
