using System;
using Cantina.Clientes;

namespace Cantina
{
    class Program
    {
        static void Main(string[] args)
        {
            TesteParte1();
        }

        public static void TesteParte1(){
            Cantina cantina = new Cantina("Cantina do Tio Bill", "Rua Oriano mendes");

            //Compra compra = new Compra();
            Cliente cliente = new Cliente("Leonarodo", "Boulevard do Arco", "(88)9.9709-3471");

            cliente.Comprar(0,3);
            cliente.Comprar(2,3);
            cliente.Comprar(1,1);
            
            Console.WriteLine(cliente.UltimaCompra());
            cliente.Compras[cliente.UltimaCompra()-1].Confirmado = true;




            Console.WriteLine("Volumes: " + cliente.Compras[0].Venda.Ticket.Produtos.Count);
            Console.WriteLine("Soma dos produtos" + cliente.Compras[0].Venda.Ticket.SomaProd);
            Console.WriteLine("Total: " + cliente.Compras[0].Venda.Total);

            //venda.Produtos = produto;
            //venda.Cancelar();
            
            //produto.Nome = "Salgado";
            /*Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Valor);*/
            Console.WriteLine(cliente.Compras[cliente.UltimaCompra()-1].Venda.Cancelada);
            //Console.WriteLine(produto.Descricao);
        }
    }
}
