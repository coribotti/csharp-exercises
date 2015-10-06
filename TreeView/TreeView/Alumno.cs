using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView
{
    class Alumno
    {
        private string _name;
        private string _numCuenta;
        private double _promedio;
        private string _group;
        /// <summary>
        /// Crea un nuevo alumno.
        /// </summary>
        /// <param name="NumCuenta">Clave única de identificación.</param>
        /// <param name="Nombre">Nombre del alumno.</param>
        /// <param name="Grupo">Grupo al que pertenece.</param>
        /// <param name="Promedio">Promedio actual.</param>
        public Alumno(string NumCuenta, string Nombre, string Grupo, double Promedio)
        {
            _numCuenta = NumCuenta;
            _name = Nombre;
            _group = Grupo;
            _promedio = Promedio;
        }
        /// <summary>
        /// La clave única con la que se identifica al almuno.
        /// </summary>
        public string NumCuenta
        {
            get
            {
                return _numCuenta;
            }
        }
        /// <summary>
        /// Nombre del alumno.
        /// </summary>
        public string Nombre
        {
            get
            {
                return _name;
            }
        }
        /// <summary>
        /// Grupo al que pertenece el alumno.
        /// </summary>
        public string Grupo
        {
            get
            {
                return _group;
            }
        }
        /// <summary>
        /// Promedio actual del alumno.
        /// </summary>
        public double Promedio
        {
            set
            {
                _promedio = value;
            }
            get
            {
                return _promedio;
            }
        }
        /// <summary>
        /// Información del alumno.
        /// </summary>
        /// <returns>Devuelve el número de cuenta y el nombre del alumno.</returns>
        public override string ToString()
        {
            return _numCuenta + ", " + _name;
        }
    }
}
