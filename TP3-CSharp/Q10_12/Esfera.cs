using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_CSharp.Q10_12
{
    internal class Esfera
    {
        private double Raio;

        public Esfera(double raio)
        {
            Raio = raio;
        }

        public double CalcularVolume()
        {
           return  (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
        }
    }
}
