using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Program
    {
        struct Carro
        {
            public string modelo;
            public int pot;
            public double km;
        }
        static void Main(string[] args)
        {
            string final;
            int carros;

            Carro Carro1;

            Console.WriteLine("Número de carros");
            carros = Convert.ToInt32(Console.ReadLine());

            Carro[] Carros = new Carro[carros];

            for (int i = 0; i < carros; i++)
            {
                Console.WriteLine("Modelo:");
                Carro1.modelo = Console.ReadLine();
                Console.WriteLine("Quilometragem:");
                Carro1.km = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Potência:");
                Carro1.pot = Convert.ToInt32(Console.ReadLine());

                final = Sub(Carro1);

                Console.WriteLine(final);
            }
        }

        static string Sub(Carro Carro1)
        {
            string modsaida, potsaida, final;

            if (Carro1.km <= 5000)
            {
                modsaida = "Novo";
            }
            else if (Carro1.km > 5000 && Carro1.km <= 30000)
            {
                modsaida = "Seminovo";
            }
            else
            {
                modsaida = "Velho";
            }

            if (Carro1.pot > 200)
            {
                potsaida = "Potente";
            }
            else if (Carro1.pot >= 120 && Carro1.pot <= 200)
            {
                potsaida = "Forte";
            }
            else
                potsaida = "Popular";

            final = String.Format("{0} - {1} - {2}", Carro1.modelo, modsaida, potsaida);

            return final;
        }
    }
}
