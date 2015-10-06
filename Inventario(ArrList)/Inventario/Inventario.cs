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
        private ArrayList _Productos;
        /// <summary>
        /// Crea un inventario con espacio para 20 productos.
        /// </summary>
        public Inventario()
        {
            _Productos = new ArrayList();
        }
        /// <summary>
        /// Agrega un producto al inventario.
        /// </summary>
        /// <param name="Product">Un producto.</param>
        public void Agregar(Producto Product)
        {
            _Productos.Add(Product);
        }
        /// <summary>
        /// Busca un producto en el inventario a partir dé un código dado.
        /// </summary>
        /// <param name="Codigo">Código del producto.</param>
        /// <returns>El producto buscado.</returns>
        public Producto Buscar(int Codigo)
        {
            Producto Res = null;
            int Max, i = 0;
            bool Encontrado = false;
            Max = _Productos.Count;
            while (!Encontrado && i < Max)
            {
                Res = (Producto)_Productos[i];
                if (Res.Codigo == Codigo)
                {
                    Encontrado = !Encontrado;
                }
            }
            return Res;
        }
        /// <summary>
        /// Elimina el producto del código especificado.
        /// </summary>
        /// <param name="Codigo">Código del producto.</param>
        public void Eliminar(int Codigo)
        {
            Producto Proc;
            int Max, i = 0;
            bool Encontrado = false;
            Max = _Productos.Count;
            while (!Encontrado && i < Max)
            {
                Proc = (Producto)_Productos[i];
                if (Proc.Codigo == Codigo)
                {
                    _Productos.RemoveAt(i);
                    Encontrado = !Encontrado;
                }
                i++;
            }
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
