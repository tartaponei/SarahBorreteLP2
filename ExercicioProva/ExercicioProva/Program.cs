using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProva
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, E, n;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int marcadas = 0, ambiguas = 0;
                string resp = "*";

                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                C = int.Parse(Console.ReadLine());
                D = int.Parse(Console.ReadLine());
                E = int.Parse(Console.ReadLine());

                if (A <= 100)
                {
                    resp = "A";
                    marcadas++;
                }

                else if (A <= 220)
                {
                    ambiguas++;
                }


                if (B <= 100)
                {
                    resp = "B";
                    marcadas++;
                }

                else if (B <= 220)
                {
                    ambiguas++;
                }


                if (C <= 100)
                {
                    resp = "C";
                    marcadas++;
                }

                else if (C <= 220)
                {
                    ambiguas++;
                }

                if (D <= 100)
                {
                    resp = "D";
                    marcadas++;
                }

                else if (D <= 220)
                {
                    ambiguas++;
                }

                if (E <= 100)
                {
                    resp = "E";
                    marcadas++;
                }

                else if (E <= 220)
                {
                    ambiguas++;
                }


                if (marcadas == 1 && ambiguas == 0)
                    Console.WriteLine(resp);
                else
                    Console.WriteLine("*");
            }
        }
    }
}
