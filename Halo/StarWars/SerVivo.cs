using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    abstract class SerVivo
    {
        protected int _vida; //Maneja la cantidad de HP que tiene el ser vivo.
        protected bool _vivo; //Indica si está vivo o muerto.
        /// <summary>
        /// Un nuevo ser vivo.
        /// </summary>
        public SerVivo()
        {
            _vivo = true; //Lo inicializa como vivo.
            _vida = 100; //Le da 100 de HP.
        }
        /// <summary>
        /// Indica si está vivo o muerto.
        /// </summary>
        public string vivo
        {
            get
            {   //Si el valor que entra en un if es TRUE (diferente de 0), entra a los parámetros de la condición, si es FALSE (0)
                //entra directo al else.
                if (_vivo) //_vivo es lo mismo que poner _vivo==true.
                    return " vivo.";
                else
                    return " muerto.";
            }
        }
        /// <summary>
        /// Vida restante.
        /// </summary>
        public int vida
        {
            get
            {
                return _vida;
            }
        }
        /// <summary>
        /// Muestra el estado del ser vivo.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (_vivo)
                return "Está" + vivo + " Con " + _vida.ToString() + " de HP.";
            else
                return "Está" + vivo;

        }
        /// <summary>
        /// El ser vivo muere...
        /// </summary>
        public void Morir()
        {
            _vivo = false;
            _vida = 0;
        }
    }
}
