using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visto_en_clase
{
    class Punto
    {
        private int _x; //Coordenada x.
        private int _y; //Coordenada y.

        public Punto()
        {
            _x = 10;    //Valores predeterminados.
            _y = 10;
        }
        
        public Punto(int x, int y)
        {
            _x = x;     //Valores que el usuario da.
            _y = y;
        }
        
        public int x
        {
            set
            {
                _x = value; //Establece la propiedad con el valor dado por el usuario.
            }
            get             //Obtiene el valor actual de la propiedad.
            {
                return _x;
            }
        }
        
        public int y
        {
            set         //Establece la propiedad con el valor dado por el usuario.
            {
                _y = value;
            }
            get
            {
                return _y;
            }
        }
        public double Distancia(int x2, int y2) //Método.
        {
            double dist = Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2));
            return dist;
        }

        public double Distancia(Punto pd)
        {
            return Distancia(pd.x, pd.y);
        }

        public override string ToString()
        {
            return "(" + _x.ToString() + "," + _y.ToString() + ")";
        }
    }

}
