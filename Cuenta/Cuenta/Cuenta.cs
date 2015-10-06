using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    class Cuenta
    {
        protected int _numero;
        protected double _saldo;
        private static int gen = 1;

        public Cuenta()
        {
            _numero = gen;
            _saldo = 0;
            gen++;
        }

        public Cuenta(double saldo)
        {
            _saldo = saldo;
            _numero = gen;
            gen++;
        }

        public int numero
        {
            get
            {
                return _numero;
            }
        }

        public double saldo
        {
            get
            {
                return _saldo;
            }
        }

        public override string ToString()
        {
            return _numero.ToString() + ": $" + _saldo.ToString();
        }

        public void Deposito(double cantidad)
        {
            _saldo += cantidad;
        }

        public bool Retiro(double cantidad)
        {
            if (cantidad < _saldo)
            {
                _saldo -= cantidad;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
