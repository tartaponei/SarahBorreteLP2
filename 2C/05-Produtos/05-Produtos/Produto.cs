using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Produtos
{
    class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public double preço { get; set; }
        public string marca { get; set; }
        public int qtdEstoque { get; set; }

        public Produto (int i, string n, double p)
        {
            id = i;
            nome = n;
            preço = p;
            qtdEstoque = 0;
        }

        public void Repor(int novaQtd)
        {
            qtdEstoque += novaQtd;
        }

        public void Retirar(int qtd)
        {
            if (qtdEstoque - qtd > qtdEstoque)
                throw new System.InvalidOperationException("A RETIRADA NÃO PODE EXCEDER A QUANTIDADE EM ESTOQUE");
            else
                qtdEstoque -= qtd;
        }

        public void Imprimir()
        {
            Console.WriteLine(String.Format("Produto: {0} - R${1:0.00} - Estoque: {2}", nome, preço, qtdEstoque));
        }
    }
}
