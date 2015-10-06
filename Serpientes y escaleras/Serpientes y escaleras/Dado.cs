using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_y_escaleras
{
    class Dado
    {
        Random gen;
        public Dado()
        {
            gen = new Random();
        }
        public int Lanzar()
        {
            return gen.Next(1, 7);
        }
    }
}
