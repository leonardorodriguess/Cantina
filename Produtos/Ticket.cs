using System;
using System.Collections.Generic;
using Cantina.Estensoes;

namespace Cantina.Produtos
{
    public class Ticket{
        private List<Produto> _produtos = new List<Produto>();
        public double SomaProd { get; private set; }
        public double Desconto { get; private set; }
        public List<Produto> Produtos 
        { 
            get{ return _produtos;} 
            set{_produtos = value;}
        }

        public Ticket (params Produto[] itens){
            _produtos.AdicionarVarios(itens);

            this.SomaProdutos();
            this.Descontos();
        }

        public Ticket (List<Produto> quentinhas){
            _produtos = quentinhas;

            this.SomaProdutos();
            this.Descontos();
        }

        private void SomaProdutos(){
            double somaVal = 0;

            foreach (Produto prod in _produtos)
            {
                somaVal += prod.Valor * prod.Quantidade;
            }    
            SomaProd = Math.Round(somaVal, 2);
        }

        

        private void Descontos(){
            int somaQuant = 0;

            foreach (Quentinha prod in _produtos)
            {
                somaQuant += prod.Quantidade;
            }
            Desconto += DescontoQuantidade(SomaProd, somaQuant);
        }
        private double DescontoQuantidade(double somaVal, int somaQuant){
            if(somaQuant >= 5)
                return Math.Round(somaVal * 0.0215, 2);
            return 0;
        }

    }
}