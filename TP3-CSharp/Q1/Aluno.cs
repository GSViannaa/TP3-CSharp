using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_CSharp.Q1
{
    class Aluno
    {

        private string nome;
        private int idade;

        public Aluno(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        } 

        public void PrintNomeEIdade()
        {
            Console.WriteLine($"Nome: {nome}, Idade; {idade}");
        }
    }
}
