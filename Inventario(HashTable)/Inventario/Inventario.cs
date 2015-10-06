using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Inventario
    {
        private Hashtable _Productos;
        /// <summary>
        /// Crea un inventario con espacio para 20 productos.
        /// </summary>
        public Inventario()
        {
            _Productos = new Hashtable();
        }
        /// <summary>
        /// Añade un producto al inventario.
        /// </summary>
        /// <param name="Product">Producto a añadir.</param>
        public void Agregar(Producto Product)
        {
            _Productos.Add(Product.Codigo, Product);
        }
        /// <summary>
        /// Busca un producto en el inventario a partir de un código dado.
        /// </summary>
        /// <param name="Codigo">Código del producto.</param>
        /// <returns>El producto buscado.</returns>
        public Producto Buscar(int Codigo)
        {
            return (Producto) _Productos[Codigo];
        }
        /// <summary>
        /// Elimina el producto del código especificado.
        /// </summary>
        /// <param name="Codigo">Código del producto.</param>
        public void Eliminar(int Codigo)
        {
            _Productos.Remove(Codigo);
        }
        /// <summary>
        /// Regresa el producto en el índice indicado.
        /// </summary>
        /// <param name="index">Índice.</param>
        /// <returns></returns>
        public string Listar()
        {
            string Lista = "";
            foreach (Producto Proc in _Productos.Values)
            {
                Lista += Proc + "\r\n";
            }
            return Lista;
        }
    }
}
