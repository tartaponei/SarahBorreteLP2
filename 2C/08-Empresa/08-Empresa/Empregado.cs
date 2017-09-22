using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Empregado : Funcionario
    {
        public int dataEntrada { get; set; }

        public Empregado(string n, string c, int nr) : base(n, c, nr) { }
    }
}
