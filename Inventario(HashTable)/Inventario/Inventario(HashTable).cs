using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Window1 : Form
    {
        Inventario Invent;
        Producto Prod;
        string Nombre;
        int Precio, Cantidad, Codigo, i, CantInv;
        public Window1()
        {
            InitializeComponent();
            Invent = new Inventario();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Recepción de los datos del producto.
            Nombre = txName.Text;
            Precio = Convert.ToInt32(txPrice.Text);
            Cantidad = Convert.ToInt32(txCant.Text);
            Codigo = Convert.ToInt32(txCode.Text);
           //Se crea el producto nuevo.
            Prod = new Producto(Codigo, Nombre, Cantidad, Precio);
            //Agrega el producto al inventario.
            Invent.Agregar(Prod);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Limpia el TextBox donde se muestra lo que hay en el inventario.
            txInv.Text = Invent.Listar();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Codigo = Convert.ToInt32(txSearchCode.Text);
            txInv.Text = Invent.Buscar(Codigo) + "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Codigo = Convert.ToInt32(txSearchCode.Text);
            Invent.Eliminar(Codigo);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Prod = Invent.Buscar(Convert.ToInt32(txSearchCode.Text));
            if (Prod.Vender(Convert.ToInt32(txHowMany.Text)))
            { }
            else
            {
                MessageBox.Show("No hay suficiente producto para vender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Prod = Invent.Buscar(Convert.ToInt32(txSearchCode.Text));
            Prod.Comprar(Convert.ToInt32(txHowMany.Text));
        }        
    }
}
