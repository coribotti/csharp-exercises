using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    //Spartan es un terrícola.
    class Spartan: Guerrero
    {
        /// <summary>
        /// Crea un nuevo Spartan (Terrícola).
        /// </summary>
        /// <param name="nombre">Nombre del Spartan.</param>
        public Spartan(string nombre)
            :base (nombre)
        {
        }
        /// <summary>
        /// El Spartan dispara.
        /// </summary>
        /// <returns>Daño inflingido.</returns>
        public int Dispara ()
        {
            int tiro; //Guarda el valor del generador de disparos del método Disparar de la clase Guerrero.
            tiro = base.Disparar(); //Invoca el método Disparar.
            if (tiro <= 4) //40% de probabilidad de hacer 20 de daño.
                return 20;
            else if (tiro <= 8) //40% de probabilidad de hacer 15 de daño.
                return 15;
            else //20% de probabilidad de fallar.
                return 0;
        }
    }
}
