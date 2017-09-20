using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    abstract class Funcionario
    {
        protected int numeroRegistro { get; set; }
        protected string nome { get; set; }
        protected string cpf;

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                if (value.Length == 11)
                    cpf = value;
            }
        }

        protected string email { get; set; }
        protected double salario { get; }
    }
}
