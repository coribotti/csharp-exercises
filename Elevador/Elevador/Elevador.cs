using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevador
{
    class Elevador
    {
        private int _pisoActual;
        private bool _puertaAbierta;
        private int _pisos;
        /// <summary>
        /// Crea un nuevo elevador de 5 pisos.
        /// </summary>
        public Elevador()
        {
            _pisoActual = 1;
            _puertaAbierta = false;
            _pisos = 5;
        }
        /// <summary>
        /// Crea un elevador con la cantidad de pisos especificada.
        /// </summary>
        /// <param name="pisos">
        /// Total de pisos del elevador.
        /// </param>
        public Elevador(int pisos)
        {
            _pisoActual = 1;
            _puertaAbierta = false;
            _pisos = pisos;
        }
        /// <summary>
        /// Devuelve el piso actual.
        /// </summary>
        public int pisoActual
        {
            get
            {
                return _pisoActual;
            }
        }
        /// <summary>
        /// Devuelve si la puerta está o no abierta.
        /// </summary>
        public bool puertaAbierta
        {
            get
            {
                return _puertaAbierta;
            }
        }
        /// <summary>
        /// Cantidad de pisos.
        /// </summary>
        public int pisos
        {
            set
            {
                _pisos = value;
            }
            get
            {
                return _pisos;
            }
        }
        //Para que aparezcan cosas en el depurador.
        public override string ToString()
        {
            string puertaAbierta = "La puerta está ";
            if (_puertaAbierta)
                puertaAbierta += "abierta.";
            else
                puertaAbierta += "cerrada.";
            return "Piso: " + _pisoActual.ToString() + " / " + _pisos.ToString();
        }
        /// <summary>
        /// Abre la puerta.
        /// </summary>
        public void abrirPuerta()
        {
            _puertaAbierta = true;
        }
        /// <summary>
        /// Cierra la puerta.
        /// </summary>
        public void cerrarPuerta()
        {
            _puertaAbierta = false;
        }
        //Maneja el comportamiento de la subida de pisos.
        private void subirPiso()
        {
            _pisoActual++;
        }
        //Maneja el comportamiento de la bajada de pisos.
        private void bajarPiso()
        {
            _pisoActual--;
        }
        /// <summary>
        /// El elevador va al piso indicado por el usuario.
        /// </summary>
        /// <param name="piso"></param>
        public void irApiso(int piso)
        {
            int i;
            cerrarPuerta();
            if (piso > _pisoActual)
               {
                for (i = _pisoActual; i < piso; i++)
                {
                    subirPiso();
                }
            }
            else
            {
                for (i = _pisoActual; i > piso; i--)
                {
                    bajarPiso();
                }
            }
        }
    }
}
