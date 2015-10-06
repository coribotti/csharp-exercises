using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Inventario
    {
        private Producto[] _Productos;
        private int ID;
        /// <summary>
        /// Crea un inventario con espacio para 20 productos.
        /// </summary>
        public Inventario()
        {
            _Productos = new Producto[20];
            ID = 0;
        }
        /// <summary>
        /// Agrega un producto al inventario.
        /// </summary>
        /// <param name="Product">Un producto.</param>
        public void Agregar(Producto Product)
        {
            _Productos[ID] = Product;
            ID++;
        }
        /// <summary>
        /// Busca un producto en el inventario a partir dé un código dado.
        /// </summary>
        /// <param name="Codigo">Código del producto.</param>
        /// <returns>El producto buscado.</returns>
        public Producto Buscar(int Codigo)
        {
            Producto Proc = null;
            int i;
            for (i = 0; i < ID; i++)
                if (_Productos[i].Codigo == Codigo)
                    Proc = _Productos[i];
            return Proc;
        }
        /// <summary>
        /// Elimina el producto del código especificado.
        /// </summary>
        /// <param name="Codigo">Código del producto.</param>
        public void Eliminar(int Codigo)
        {
            int i = 0, j;
            while (_Productos[i].Codigo != Codigo && i <= ID)
            {
                i++;
            }
            if (_Productos[i].Codigo == Codigo)
            {
                _Productos[i] = null;

            }
            for (j = i; j < ID; j++)
            {
                _Productos[j] = _Productos[j + 1];
            }
            ID--;
        }
        /// <summary>
        /// Regresa el producto en el índice indicado.
        /// </summary>
        /// <param name="index">Índice.</param>
        /// <returns></returns>
        public string Listar()
        {
            string Lista = "";
            foreach (Producto Proc in _Productos)
            {
                Lista += Proc + "\r\n";
            }
            return Lista;
        }
    }
}
