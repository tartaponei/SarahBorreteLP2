﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg = new Mensagem();
            int n = 1;

            while (n != 0)

            {
                Console.WriteLine("1- Codificar");
                Console.WriteLine("2- Decodificar");
                Console.WriteLine("3- Transmitir");
                Console.WriteLine("0- Sair");

                n = int.Parse(Console.ReadLine());

                if (n != 0)
                {
                    if (n == 1)
                        Console.WriteLine(msg.Codificar());
                    else if (n == 2)
                        Console.WriteLine(msg.Decodificar());
                }
                else
                    break;
            }
        }
    }
}
