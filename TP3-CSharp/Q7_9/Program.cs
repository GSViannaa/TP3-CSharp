using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_CSharp.Q7_9
{
    class Program
    {
        public static void Main()
        {
            Matricula matricula = new Matricula("Gabriel", "Eng. Software", 0101, "Ativa", DateTime.Today.ToString());

            matricula.ExibirInformacoes();

            matricula.Trancar();

            matricula.ExibirInformacoes();

            matricula.Reativar();

            matricula.ExibirInformacoes();
        }
    }
}
