using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_y_escaleras
{
    class Tablero
    {
        private int[] _tablero;
        /// <summary>
        /// Crea un tablero de juego con 25 casillas.
        /// </summary>
        public Tablero()
        {
            _tablero = new int[26]; //Tablero de 25 posiciones (empezando en 0 como Inicio).
            int i;
            for (i = 0; i < 26; i++)
                _tablero[i] = i; //Inicialización de los números de las casillas del tablero.
            //Declaración de las serpientes y escaleras dentro del juego.
            _tablero[3] = 7;
            _tablero[6] = 17;
            _tablero[9] = 20;
            _tablero[23] = 13;
            _tablero[24] = 8;
            _tablero[16] = 10;
        }
        /// <summary>
        /// Determina si hay serpiente, escalera o nada en la casilla.
        /// </summary>
        /// <param name="posicion">Recibe la casilla actual del jugador.</param>
        /// <returns>Devuelve la posición a la que deberá moverse después.</returns>
        /// <return>Devuelve 0 si se ha llegado a la última casilla.</return>
        public int QueHay(int posicion)
        {
            if (posicion < 26)
                return _tablero[posicion];
            else
                return 0;
        }
    }
}

