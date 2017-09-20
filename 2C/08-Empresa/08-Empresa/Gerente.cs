using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Gerente
    {
        private int numeroRegistro { get; }
        private string nome { get; set; }
        private string cpf;

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

        private string email { get; set; }
        private double salario { get; }

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
