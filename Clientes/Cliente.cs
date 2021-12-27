using System;
using System.Collections.Generic;

namespace Cantina.Clientes
{
    public class Cliente 
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        private List<Compra> _compras = new List<Compra>();
        public List<Compra> Compras 
        {
            get{return _compras;}
            set{_compras = value;} 
        }

        public Cliente(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        /*public void novaCompra ()
        {
            if(!UltimaCompraPendente())
                _compras.Add(new Compra());
            else
                Console.WriteLine("Porfavor, concluir compra pendente ou cancelar ");
        }*/

        public void Comprar(int indice, int valor)
        {
            if(UltimaCompraPendente())
            {
                _compras.Add(new Compra(indice, valor));
                //_compras[UltimaCompra()].SelecionarItemTicket(indice, valor);
            }
            else
                _compras[UltimaCompra()-1].SelecionarItemTicket(indice, valor);
        }
        public void CancelarUltimaCompraPendente()
        {
            
        }

        public void CancelarUltimaCompraConcluida()
        {
            
        }

        private bool UltimaCompraPendente(){
            if(UltimaCompra() == 0)
                return true; 
            
            return _compras[UltimaCompra()-1].Confirmado;
        }

        public int UltimaCompra(){
            /*if(_compras.Count == 0)
                return 0;*/
            return _compras.Count;
        }
    }    
}