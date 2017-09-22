using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    abstract class Funcionario
    {
        public int numeroRegistro { get; set; }
        public string nome { get; set; }
        protected string cpf;

        public string Cpf
        {
            get
            {
                return cpf;
            }
        }

        protected string email { get; set; }
        protected double salario { get; }

        public Funcionario(string n, string c, int nr)
        {
            nome = n;
            numeroRegistro = nr;

            if (c.Length == 11)
                cpf = c;
        }
    }
}
