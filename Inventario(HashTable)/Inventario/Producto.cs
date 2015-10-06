using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Producto
    {
        private string _name;
        private int _quantity;
        private int _code;
        private double _price;
        /// <summary>
        /// Crea un nuevo producto con ciertas características.
        /// </summary>
        /// <param name="Nombre">Nombre del producto.</param>
        /// <param name="Cant">Cantidad del producto disponible.</param>
        /// <param name="Codigo">Código único.</param>
        /// <param name="Precio">Precio del producto.</param>
        public Producto(int Codigo, string Nombre, int Cant, double Precio)
        {
            _name = Nombre;
            _quantity = Cant;
            _code = Codigo;
            _price = Precio;
        }
        /// <summary>
        /// Devuelve el nombre del producto.
        /// </summary>
        public string Nombre
        {
            get 
            {
                return _name;
            } 
        }
        /// <summary>
        /// Devuelve la cantidad de producto.
        /// </summary>
        public int Cantidad
        {
            set
            {
                _quantity = value;
            }
            get
            {
                return _quantity;
            }
        }
        /// <summary>
        /// Devuelve el código único del producto.
        /// </summary>
        public int Codigo
        {
            get 
            { 
                return _code; 
            }
        }
        /// <summary>
        /// Devuelve el precio del producto.
        /// </summary>
        public double Precio
        {
            get 
            {
                return _price; 
            }
        }
        /// <summary>
        /// Vende cierta cantidad del producto, si no hay suficiente, no se vende.
        /// </summary>
        /// <param name="Cantidad">Cantidad a vender</param>
        /// <returns></returns>
        public bool Vender(int Cantidad)
        {
            int Sold;
            Sold = _quantity - Cantidad;
            if (Sold < 0)
            {
                return false;
            }
            else
            {
                _quantity -= Cantidad;
                return true;
            }
        }
        /// <summary>
        /// Compra más del producto.
        /// </summary>
        /// <param name="Cantidad">Cantidad a comprar.</param>
        public void Comprar(int Cantidad)
        {
            _quantity += Cantidad;
        }
        /// <summary>
        /// Muestra información del producto.
        /// </summary>
        /// <returns>Devuelve nombre y precio del producto.</returns>
        public override string ToString()
        {
            return _name  + " Código: " + Codigo + ", Precio: $" + _price + ", Cantidad: " + _quantity;
        }
    }
}
