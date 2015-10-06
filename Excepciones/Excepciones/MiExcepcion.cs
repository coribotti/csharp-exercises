using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class MiExcepcion : Exception
    {
        private string _m;
        public MiExcepcion() :base()
        {
        }

        public MiExcepcion(string m)
            : base(m)
        {
            _m = m;
        }

        public override string ToString()
        {
            return base.ToString() + _m;
        }
    }
}
