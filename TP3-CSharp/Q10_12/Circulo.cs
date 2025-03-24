using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_CSharp.Q10_12
{
    internal class Circulo
    {
        private double Raio;

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }
    }
}
