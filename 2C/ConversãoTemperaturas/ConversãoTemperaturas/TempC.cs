using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversãoTemperaturas
{
    class TempC
    {
        public double valor;

        public double EmFahrenheit()
        {
            return 1.8 * valor + 32;
        }

        public double EmKelvin()
        {
            return valor + 273;
        }
    }
}
