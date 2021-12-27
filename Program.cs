using System;
using Cantina.Produtos;
using Cantina.Vendas;

namespace Cantina
{
    class Program
    {
        static void Main(string[] args)
        {
            TesteParte1();
        }

        public static void TesteParte1(){
            Produto pratofeito = new Produto("P. F.", 12);
            pratofeito.Quantidade = 4;
            Produto pratoempresarial = new Produto("P. Emp", 18);
            Ticket ticket = new Ticket(pratofeito, pratoempresarial);
            Venda venda = new Venda(ticket);

            Console.WriteLine("quantidade de produtos: " + venda.Ticket.Produtos.Count);

            Console.WriteLine("Soma dos produtos" + venda.Ticket.SomaProd);
            Console.WriteLine("Total: " + venda.Total);

            //venda.Produtos = produto;
            //venda.Cancelar();
            
            //produto.Nome = "Salgado";
            /*Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Valor);*/
            Console.WriteLine(venda.Cancelada);
            //Console.WriteLine(produto.Descricao);
        }
    }
}
