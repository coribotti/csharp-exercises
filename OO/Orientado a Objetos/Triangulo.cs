using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientado_a_Objetos
{
    class Triangulo
    {
        private int _base;
        private int _altura;

        public Triangulo()
        {
            _base = _altura = 10;
        }

        public Triangulo(int Base, int Altura)
        {
            _base = Base;
            _altura = Altura;
        }

        public int Base
        {
            set
            {
                _base = value;
            }
            get
            {
                return _base;
            }
        }

        public int Altura
        {
            set
            {
                _altura = value;
            }
            get
            {
                return _altura;
            }
        }
    }
}
