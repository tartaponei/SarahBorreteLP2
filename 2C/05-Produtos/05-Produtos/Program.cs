using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            int comando1 = 4, id, comando3 = 1;
            string nome;
            double preço;

            while (comando1 == 4)
            {
                Console.WriteLine("1- Novo produto");
                Console.WriteLine("0- Sair");
                comando1 = int.Parse(Console.ReadLine());

                if (comando1 == 1)
                {
                    Console.WriteLine("ID:");
                    id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nome:");
                    nome = Console.ReadLine();

                    Console.WriteLine("Preço (colocar com vírgula):");
                    preço = double.Parse(Console.ReadLine());

                    Produto p = new Produto(id, nome, preço);

                    while (comando3 == 1)
                    {
                        Console.WriteLine("1- Reposição de estoque");
                        Console.WriteLine("2- Retirada de estoque");
                        Console.WriteLine("3- Exibir informações sobre o produto");
                        Console.WriteLine("0- Sair");
                        int comando2 = int.Parse(Console.ReadLine());

                        if (comando2 == 1)
                        {
                            Console.WriteLine("Valor a ser reposto:");
                            p.Repor(int.Parse(Console.ReadLine()));
                        }

                        else if (comando2 == 2)
                        {
                            Console.WriteLine("Valor a ser retirado:");
                            p.Retirar(int.Parse(Console.ReadLine()));
                        }

                        else if (comando2 == 3)
                            p.Imprimir();

                        else if (comando2 == 0)
                            break;

                        else
                            throw new System.InvalidOperationException("COMANDO INVÁLIDO");
                    }
                }

                else if (comando1 == 0)
                    break;

                else
                    throw new System.InvalidOperationException("COMANDO INVÁLIDO");
            }
        }
    }
}
