using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    abstract class Guerrero : SerVivo
    {
        protected string _name; //Nombre del guerrero.
        private static Random generador= new Random(); //Generador de números aleatorios para la probabilidad del disparo.
        /// <summary>
        /// Crea un nuevo guerrero.
        /// </summary>
        /// <param name="name">Recibe el nombre del guerrero.</param>
        public Guerrero(string name)
            : base() //Llama al constructor vacío base de la clase SerVivo.
        {
            _name = name;
        }
        /// <summary>
        /// El nombre del guerrero.
        /// </summary>
        public string name
        {
            get
            {
                return _name;
            }
        }
        /// <summary>
        /// Recibe daño.
        /// </summary>
        /// <param name="damage">Daño recibido.</param>
        public void TakeDamage(int damage)
        {
            _vida -= damage;
            if (_vida <= 0)
                Morir();
        }
        /// <summary>
        /// El guerrero dispara.
        /// </summary>
        /// <returns></returns>
        protected int Disparar()
        {
            return generador.Next(1, 11); //Genera la probabilidad del disparo.
            //Marciano                          Terrícola
            //30%---> 30 de daño                40%---> 20 de daño
            //40%---> 15 de daño                40%---> 15 de daño
            //20%---> 5 de daño                 20%---> Falla
            //10%---> Falla
        }

        /// <summary>
        /// Regresa el nombre y estado del guerrero.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _name + ": " + base.ToString(); //base.ToString() utiliza el método .ToString de la clase base (SerVivo).
        }
    }
}
