using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Terceirizado : Funcionario
    {
        private int dataEntrada { get; }

        private string empresaMatriz { get; }

        public Terceirizado(string n, string c, int nr, string emp) : base(n, c, nr)
        {
            empresaMatriz = emp;
        }
    }
}
