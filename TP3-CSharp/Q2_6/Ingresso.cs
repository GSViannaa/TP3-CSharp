using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_CSharp.Q2_6
{
    class Ingresso
    {
        private string nomeDoShow;
        private double preco;
        private int quantidadeDisponivel;

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }


        public string GetNomeDoShow()
        {
            return nomeDoShow;
        }

        public double GetPreco()
        {
            return preco;
        }

        public int GetQuantidadeDisponivel()
        {
            return quantidadeDisponivel;
        }

    


        public void SetNomeDoShow(string novoNome)
        {
            nomeDoShow = novoNome;
        }

        public void SetPreco(double novoPreco)
        {
            if (novoPreco > 0) 
            {
                preco = novoPreco;
            }
            else
            {
                Console.WriteLine("O preço deve ser positivo");
            }
        }

        public void SetQuantidadeDisponivel(int novaQtd)
        {
            if (novaQtd >= 0) 
            {
                quantidadeDisponivel = novaQtd;
            }
            else
            {
                Console.WriteLine("A quantidade não pode ser negativa.");
            }
        }
        public void exibirInformacoes()
        {
            Console.WriteLine("Informações do Show");
            Console.WriteLine($"Nome do show: {nomeDoShow}");
            Console.WriteLine($"Preco do show: {preco}");
            Console.WriteLine($"Quantidade disponivel: {quantidadeDisponivel}");
        }
    }       
}
