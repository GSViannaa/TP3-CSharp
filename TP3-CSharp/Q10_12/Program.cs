using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_CSharp.Q10_12
{
    internal class Program
    {
        public static void Main()
        {
            Circulo circulo = new Circulo(3);
            Esfera esfera = new Esfera(5);

            Console.WriteLine(circulo.CalcularArea().ToString("F2"));
            Console.WriteLine(esfera.CalcularVolume().ToString("F2"));
        }
    }
}
