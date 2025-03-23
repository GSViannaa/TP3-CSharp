using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_CSharp.Q7_9
{
    class Matricula
    {
        private string nome;
        private string curso;
        private int numeroMatricula;
        private string situacao;
        private string dataInicial;

        public Matricula(string nome, string curso, int numeroMatricula, string situacao, string dataInicial)
        {
            this.nome = nome;
            this.curso = curso;
            this.numeroMatricula = numeroMatricula;
            this.situacao = situacao;
            this.dataInicial = dataInicial;
        }

        public void Trancar()
        {
            situacao = "Matricula Trancada";
        } 
        public void Reativar()
        {
            situacao = "Matrícula Ativa";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Informações do aluno");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Situação da matrícula: {situacao} ");
            Console.WriteLine($"Data de inicio: {dataInicial}");

        }
    }

}
