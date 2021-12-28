using System;
using System.Collections.Generic;
using Cantina.Produtos;
using Cantina.Vendas;

namespace Cantina.Clientes
{
    public class Compra{
        //private Menu _menu = new Menu();
        /*public Menu Menu
        {
            get{return _menu;} 
            set{_menu = value;}
        }*/
        public Ticket Ticket { get; private set; }
        public Venda Venda { get; set; }
        public bool _confirmado;
        public bool Confirmado 
        {
            get{return _confirmado;} 
            set
            {   
                _confirmado = value;
                if(_confirmado)
                {
                    Ticket = new Ticket(_produtos);
                    Venda = new Venda(Ticket);
                }
            } 
        }
        private List<Produto> _produtos = new List<Produto>();
        public List<Produto> Produtos 
        {
            get{return _produtos;} 
            private set{_produtos = value;} 
        }
        
        public Compra(int indice, int quantidade)
        {
            SelecionarItemTicket(indice, quantidade);
        }

        public void SelecionarItemTicket(int indice, int quantidade)
        {   
            if (Cantina.AbrirCantina)
            {
                if(!_confirmado){
                    // Console.WriteLine("Cantina Aberta");
                    SelecionarQuantidade(indice, quantidade);
                    _produtos.Add(Menu.ItemQuentinha[indice]);
                }else{
                    Console.WriteLine("Após confirmado para adicionar mais ítens é necessário fazer uma nova Compra");
                }
            }else
            {
                Console.WriteLine("Cantina Fechada não é possível comprar ");
            }            
        }

        public void SelecionarQuantidade(int indice, int quantidade)
        {
            Menu.ItemQuentinha[indice].Quantidade = quantidade;
        }
    }

}