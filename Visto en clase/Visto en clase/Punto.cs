using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visto_en_clase
{
    class Punto
    {
        private int _x;
        private int _y;

    public Punto()
    {
        _x = 10;
        _y = 10;
    }
    public Punto(int x, int y)
    {
        _x = x;
        _y = y;
    }
    public int x
    {
        set
        {
            _x = value;
        }
        get
        {
            return _x;
        }
    }
    public int y
    {
        set
        {
            _y = value;
        }
        get
        {
            return _y;
        }
    }
    public double Dis(int x2, int y2)
    {
        double dist = Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2));
        return dist;

    }
  }

}
