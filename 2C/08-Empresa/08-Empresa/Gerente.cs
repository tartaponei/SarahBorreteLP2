using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Gerente : Funcionario
    {
        private double bonus { get; }

        public Gerente(string n, string c, int nr, int b)
        {
            nome = n;
            cpf = c;
            numeroRegistro = nr;
            bonus = b;
        }
    }
}
