using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Gerente : Funcionario
    {
        static public double bonus { get; set; }

        public Gerente(string n, string c, int nr, double b) : base(n, c, nr)
        {
            bonus = b;
        }
    }
}
