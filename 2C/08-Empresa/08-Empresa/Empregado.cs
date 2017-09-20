using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Empregado
    {
        public string Gerente;
        public int DataEntrada;

        private int numRegistro;
        private int salario;
        public string nome;
        public int cpf { get; set; }
        public string email;

        public Empregado(string x, int y)
        {
            Gerente = x;
            numRegistro = y;
        }
    }
}
