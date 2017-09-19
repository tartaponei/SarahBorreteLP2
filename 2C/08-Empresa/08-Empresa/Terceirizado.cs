using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Terceirizado
    {
        public string Setor;
        public int DataEntrada;
        private string EmpMatriz;

        private int numRegistro;
        private int salario;
        public string nome;
        public int cpf { get; set; }
        public string email;

        public Terceirizado(string x, string y, int z)
        {
            Setor = x;
            EmpMatriz = y;
            numRegistro = z;
        }
    }
}
