using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puntos
{
    class Punto
    {
        //Variables que almacenan los datos de la coordenada (punto).
        private int _x;
        private int _y;
        /// <summary>
        /// Crea una nueva coordenada (punto).
        /// </summary>
        /// <param name="x">Valor de x.</param>
        /// <param name="y">Valor de y.</param>
        public Punto(int x, int y)
        {
            _x = x;
            _y = y;
        }
        /// <summary>
        /// Contiene el valor de x.
        /// </summary>
        public int x
        {
            set
            {
                _x = value;
            }

            get
            {
                return _x;
            }
        }
        /// <summary>
        /// Contiene el valor de y.
        /// </summary>
        public int y
        {
            set
            {
                _y = value;
            }

            get
            {
                return _y;
            }
        }
        /// <summary>
        /// Calcula la distancia entre el punto actual y un punto dado.
        /// </summary>
        /// <param name="x2">Valor de x del punto dado.</param>
        /// <param name="y2">Valor de y del punto dado.</param>
        /// <returns>La distancia entre ambos puntos.</returns>
        public double Distancia(int x2, int y2)
        {
            double dist;
            dist = Math.Sqrt(Math.Pow((_x -x2), 2) + Math.Pow ((_y - y2), 2));
            return dist;
        }
    }
}
