using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string modelo, final;
            int pot, carros;
            double km;
            Console.WriteLine("Número de carros");
            carros = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < carros; i++)
            {
                Console.WriteLine("Modelo:");
                modelo = Console.ReadLine();
                Console.WriteLine("Quilometragem:");
                km = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Potência:");
                pot = Convert.ToInt32(Console.ReadLine());

                final = Sub(modelo, km, pot);

                Console.WriteLine(final);
            }
        }

        static string Sub (string modelo, double km, int pot)
        {
            string modsaida, potsaida, final;

            if (km <= 5000)
            {
                modsaida = "Novo";
            }
            else if (km > 5000 && km <= 30000)
            {
                modsaida = "Seminovo";
            }
            else
            {
                modsaida = "Velho";
            }

            if (pot > 200)
            {
                potsaida = "Potente";
            }
            else if (pot >= 120 && pot <= 200)
            {
                potsaida = "Forte";
            }
            else
                potsaida = "Popular";

            final = String.Format("{0} - {1} - {2}", modelo, modsaida, potsaida);

            return final;
        }
    }
}
