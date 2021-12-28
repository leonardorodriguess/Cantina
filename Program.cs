using System;
using Cantina.Clientes;
using Cantina.Produtos;

namespace Cantina
{
    class Program
    {
        static void Main(string[] args)
        {
            TesteParte1();
        }

        public static void TesteParte1(){
            Cantina cantina = new Cantina("Cantina do Tio Bill", "Rua Oriano mendes, 624");

            Menu.AddQuentinha("Simples", 10.0);
            Menu.AddQuentinha("Prato Feito", 13.0);
            Menu.AddQuentinha("Grande", 18.0);


            ListaClientes clientes = new ListaClientes("Leonardo", "Boulevard do Arco, 551", "(88)9.9709-3471");
            

            clientes.Clientes[0].Comprar(2,3); // parâmetros (índice da quentinha, quantidade)
            clientes.Clientes[0].Comprar(0,3); // parâmetros (índice da quentinha, quantidade)
            clientes.Clientes[0].Comprar(1,1); // parâmetros (índice da quentinha, quantidade)
            
            // confirmar compra, não pode mais adicionar mais pratos no ticket
            clientes.Clientes[0].Compras[clientes.Clientes[0].UltimaCompra()-1].Confirmado = true;

            Console.WriteLine("-----------------------------Cliente------------------------------");
            Console.WriteLine("Nome: " + clientes.Clientes[0].Nome);
            Console.WriteLine("Endereco: " + clientes.Clientes[0].Endereco);
            Console.WriteLine("Telefone: " + clientes.Clientes[0].Telefone);
            Console.WriteLine("");

            Console.WriteLine("-----------------------------Pedidos------------------------------");
            Console.WriteLine("Tipo quentinha: " + clientes.Clientes[0].Compras[0].Ticket.Produtos[0].Nome
                            + "\t  valor: " + clientes.Clientes[0].Compras[0].Ticket.Produtos[0].Valor
                            + "\t quantidade: " + clientes.Clientes[0].Compras[0].Ticket.Produtos[0].Quantidade);

            Console.WriteLine("Tipo quentinha: " + clientes.Clientes[0].Compras[0].Ticket.Produtos[1].Nome
                            + "\t  valor: " + clientes.Clientes[0].Compras[0].Ticket.Produtos[1].Valor
                            + "\t quantidade: " + clientes.Clientes[0].Compras[0].Ticket.Produtos[1].Quantidade);

            Console.WriteLine("Tipo quentinha: " + clientes.Clientes[0].Compras[0].Ticket.Produtos[2].Nome
                            + "\t  valor: " + clientes.Clientes[0].Compras[0].Ticket.Produtos[2].Valor
                            + "\t quantidade: " + clientes.Clientes[0].Compras[0].Ticket.Produtos[2].Quantidade);

            Console.WriteLine("");

            Console.WriteLine("Soma dos produtos: " + clientes.Clientes[0].Compras[0].Ticket.SomaProd);
            Console.WriteLine("Desconto: " + clientes.Clientes[0].Compras[0].Ticket.Desconto);

            Console.WriteLine("");

            Console.WriteLine("Taxa de entrega: " + clientes.Clientes[0].Compras[0].Venda.Frete);
            Console.WriteLine("Total: " + clientes.Clientes[0].Compras[0].Venda.Total);

            Console.WriteLine("Tempo de espera: " + clientes.Clientes[0].Compras[0].Venda.EsperaMin
                            + " - " + clientes.Clientes[0].Compras[0].Venda.EsparaMax + " min");

            
            //Cancelando pedido
            Console.WriteLine("");
            Console.WriteLine("------------------------Cancelando Pedido------------------------");
            clientes.Clientes[0].Compras[0].Venda.Cancelar(); //Se não tiver sido entregue ou finalizado
            Console.WriteLine("Cancelar pedido: " + clientes.Clientes[0].Compras[0].Venda.Cancelada 
                            + "\t Pedido Cancelado" );


        }
    }
}
