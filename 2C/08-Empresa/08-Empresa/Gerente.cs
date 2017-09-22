using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Gerente : Funcionario
    {
        public double bonus { get; private set; }

        public Gerente(string n, string c, int nr, double b) : base(n, c, nr)
        {
            bonus = b;
        }
    }
}
