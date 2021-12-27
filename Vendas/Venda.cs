using System;
using System.Collections.Generic;
using Cantina.Produtos;

namespace Cantina.Vendas{
    public class Venda{
        public Ticket Ticket { get; set; }
        public double Total { get; set; }
        public bool Cancelada { get; private set; }
        public bool Finalizada { get; private set; }
        public bool Entrega { get; private set; }
        private double _frete = 4;
        public double Frete 
        { 
            get{return _frete;} 
            set{_frete = value;}
        }
        private int _esperaMin = 30;
        private int _esperaMax = 90;
        public int EsperaMin 
        { 
            get{return _esperaMin;}
            set{_esperaMin = value;} 
        }  //Em minutos
        public int EsparaMax 
        {   
            get{return _esperaMax;} 
            set{_esperaMax = value;} 
        }  //Em minutos

        public Venda(Ticket ticket){
            Cancelada = false;
            Finalizada = false;
            Entrega = false;

            Ticket = ticket;

            Total = Math.Round(ticket.SomaProd - ticket.Desconto + _frete, 2);
        }

        public void Cancelar(){
            if(!Finalizada && !Entrega)
                Cancelada = true;
        }

        public void Finalizar(){
            if(!Cancelada && Entrega)
                Finalizada = true;
        }


    }
}