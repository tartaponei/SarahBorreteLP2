using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Gerente
    {
        private int bonus { get; set; }

        private int numRegistro;
        private int salario;
        public string nome;
        public int cpf { get; set; }
        public string email;

        public Gerente(int x, int y)
        {
            bonus = x;
            numRegistro = y;
        }
    }
}
