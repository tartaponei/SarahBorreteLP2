using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competição_de_Corrida
{
    public class Competidor
    {
        public double t1;
        public double t2;
        public double t3;

        public double TempoOficial()
        {
            if (t1 < t2 && t1 < t3)
                return t2 + t3;

            else if (t2 < t1 && t2 < t3)
                return t1 + t3;

            else
                return t1 + t2;
        }
    }
}
