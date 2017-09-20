using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Conversor
{
    static class Converter
    {
        // MASSA
        public static void KgParaGrama(double kg)
        {
            Console.WriteLine("{0} g", kg * 1000);
        }

        public static void KgParaTonelada(double kg)
        {
            Console.WriteLine("{0} t", kg / 1000);
        }

        public static void KgParaLibra(double kg)
        {
            Console.WriteLine("{0} lb", kg * 2.20462);
        }

        // TEMPERATURA
        public static void CelsiusParaFahrenheit(double c)
        {
            Console.WriteLine("{0} F°", 1.8 * c + 32.0);
        }

        public static void FahrenheitParaKelvin(double f)
        {
            Console.WriteLine("{0} K", (f + 459.67) * 5 / 9);
        }

        public static void KelvinParaCelsius(double k)
        {
            Console.WriteLine("{0} C°", k - 273.0);
        }

        //DISTÂNCIA
        public static void MetroParaKm(double m)
        {
            Console.WriteLine("{0} km", m / 1000);
        }

        public static void KmParaMilha(double km)
        {
            Console.WriteLine("{0} mi", km * 0.62137);
        }

        public static void MetroParaPé(double m)
        {
            Console.WriteLine("{0} ft", m * 3.2808);
        }

        public static void MetroParaPolegada(double m)
        {
            Console.WriteLine("{0} in", m * 39.370);
        }

        public static void PolegadaParaPé(double p)
        {
            Console.WriteLine("{0} ft", p * 0.083333);
        }
    }
}
