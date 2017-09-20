using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Empregado : Funcionario
    {
        private int dataEntrada { get; }

        public Empregado(string n, string c, int nr)
        {
            nome = n;
            cpf = c;
            numeroRegistro = nr;
        }
    }
}
