using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    class CuentaInversion : Cuenta
    {
        private double _interes;
        
        public CuentaInversion()
            :base()
        {
            _interes = 0.1;
        }

        public CuentaInversion(double saldo)
            : base(saldo)
        {
            _interes = 0.1;
            _saldo = saldo * 1.1;
        }

        public string interes
        {
            get
            {
                return String.Format("{0:P}", _interes);
            }
        }

        public override string ToString()
        {
            return "#" + _numero.ToString() + ": " + String.Format("{0:C}", _saldo);
        }

    }
}
