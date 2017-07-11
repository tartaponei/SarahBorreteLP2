using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosHermione
{
    class Livro
    {
        public string nome;
        public int pags, diasDev;

        public int TempoDeLeitura(int paghr)
        {
            return pags / paghr;
        }
    }
}
