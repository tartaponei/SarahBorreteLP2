using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            int comando1, comando2, valor, i = 1;

            while (i == 1) {
                Console.WriteLine("1- Converter massas");
                Console.WriteLine("2- Converter temperaturas");
                Console.WriteLine("3- Converter distâncias");
                Console.WriteLine("0- Sair");
                comando1 = int.Parse(Console.ReadLine());

                if (comando1 == 1)
                {
                    Console.WriteLine("1- Kg em Gramas");
                    Console.WriteLine("2- Kg em Toneladas");
                    Console.WriteLine("3- Kg em Libras");
                    comando2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Valor:");
                    valor = int.Parse(Console.ReadLine());

                    if (comando2 == 1)
                        Converter.KgParaGrama(valor);
                    else if (comando2 == 2)
                        Converter.KgParaTonelada(valor);
                    else if (comando2 == 3)
                        Converter.KgParaLibra(valor);
                    else
                        throw new System.InvalidOperationException("COMANDO INVÁLIDO");
                }

                else if (comando1 == 2)
                {
                    Console.WriteLine("1- Celsius em Fahrenheit");
                    Console.WriteLine("2- Fahrenheit em Kelvin");
                    Console.WriteLine("3- Kelvin em Celsius");
                    comando2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Valor:");
                    valor = int.Parse(Console.ReadLine());

                    if (comando2 == 1)
                        Converter.CelsiusParaFahrenheit(valor);
                    else if (comando2 == 2)
                        Converter.FahrenheitParaKelvin(valor);
                    else if (comando2 == 3)
                        Converter.KelvinParaCelsius(valor);
                    else
                        throw new System.InvalidOperationException("COMANDO INVÁLIDO");
                }

                else if (comando1 == 3)
                {
                    Console.WriteLine("1- Metros em Km");
                    Console.WriteLine("2- Km em Milhas");
                    Console.WriteLine("3- Metros em Pés");
                    Console.WriteLine("4- Metros em Polegadas");
                    Console.WriteLine("5- Polegadas em Pés");
                    comando2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Valor:");
                    valor = int.Parse(Console.ReadLine());

                    if (comando2 == 1)
                        Converter.MetroParaKm(valor);
                    else if (comando2 == 2)
                        Converter.KmParaMilha(valor);
                    else if (comando2 == 3)
                        Converter.MetroParaPé(valor);
                    else if (comando2 == 4)
                        Converter.MetroParaPolegada(valor);
                    else if (comando2 == 5)
                        Converter.PolegadaParaPé(valor);
                    else
                        throw new System.InvalidOperationException("COMANDO INVÁLIDO");
                }

                else if (comando1 == 0)
                    break;

                else
                    throw new System.InvalidOperationException("COMANDO INVÁLIDO");
            }
           
        }
    }
}
