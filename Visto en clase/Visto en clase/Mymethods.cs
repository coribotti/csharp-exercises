using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visto_en_clase
{
    class Mymethods
    {
        /// <summary>
        /// Calcula el factorial de un número.
        /// </summary>
        /// <param name="numero">
        /// Número a evaluarse.
        /// </param>
        /// <returns></returns>
        public int factorial (int numero) 
        {
            int i, res=1;
            for (i=1; i<=numero; i++) 
            {
                res*=i;
            }
            return res;
        }

        /// <summary>
        /// Calcula la constante matemática de un número.
        /// </summary>
        /// <param name="n">
        /// Cantidad de términos a evaluar.
        /// </param>
        /// <returns></returns>
        public double constante(int n)
        {
            double res = 1;
            int i;
            for (i = 1; i <= n; i++)
            {
                res += (Convert.ToDouble(n) / factorial(n));
            }
            return res;
        }
        /// <summary>
        /// Calcula euler a la x.
        /// </summary>
        /// <param name="x">
        /// Número base.
        /// </param>
        /// <param name="numero">
        /// Número a evaluar.
        /// </param>
        /// <returns></returns>
        public double euler(int x, int numero)
        {
            double res = 1;
            int i;
            for (i = 1; i <= numero; i++)
            {
                res += (Math.Pow(Convert.ToDouble(x), Convert.ToDouble(i))) / factorial(i);
            }
            return res;
        }
        /// <summary>
        /// Obtiene el promedio.
        /// </summary>
        /// <param name="sumatoria">
        /// La sumatoria de los números evaluados.
        /// </param>
        /// <param name="totalNumeros">
        /// El total de números.
        /// </param>
        /// <returns></returns>
        public double promedio(int sumatoria, int totalNumeros)
        {
            double res = 0;
            res = Convert.ToDouble(sumatoria) / Convert.ToDouble(totalNumeros);
            return res;
        }
        /// <summary>
        /// Regresa el número mayor.
        /// </summary>
        /// <param name="numeros">
        /// Un vector contenedor de los números a evaluar.
        /// </param>
        /// <param name="totalNumeros">
        /// El total de números.
        /// </param>
        /// <returns></returns>
        public int numeroMayor(int[] numeros, int totalNumeros)
        {
            int temp = 0, i;
            for (i = 0; i < totalNumeros; i++)
            {
                if (numeros[i] > temp)
                {
                    temp = numeros[i];
                }
            }
            return temp;
        }
        /// <summary>
        /// Calcula el numero primo.
        /// </summary>
        /// <param name="numero">
        /// Número a evaluar.
        /// </param>
        /// <returns></returns>
        public bool Primo(int numero)
        {
            int i, contador = 0;
            //Analiza los números anteriores al número dado para buscar divisores.
            for (i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    //Por cada divisor aumenta en 1 el contador.
                    contador++;
                }
            }
            //Si el contador es menor o igual a 2, el número es primo, caso contrario, no.
            if (contador <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
