using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{   //Covenant = marciano.
    class Covenant : Guerrero
    {
        public Covenant(string nombre)
            : base(nombre)
        {
        }
        /// <summary>
        /// El covenant dispara.
        /// </summary>
        /// <returns>Daño inflingido.</returns>
        public int Dispara()
        {
            int tiro = base.Disparar();
            if (tiro <= 3) //30% de probabilidad de hacer 30 de daño.
                return 30;
            else if (tiro <= 7) //40% de probabilidad de hacer 15 de daño.
                return 15;
            else if (tiro <= 9) //20% de probabilidad de hacer 5 de daño.
                return 5;
            else //10% de probabilidad de fallar.
                return 0;
        }
    }
}
