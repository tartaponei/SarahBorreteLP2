using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Empregado
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

        private int dataEntrada { get; }

        public Empregado(string n, string c, int nr)
        {
            nome = n;
            cpf = c;
            numeroRegistro = nr;
        }
    }
}
