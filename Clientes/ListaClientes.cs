using System.Collections.Generic;

namespace Cantina.Clientes
{
    public class ListaClientes
    {
        List<Cliente> _clientes = new List<Cliente>();
        public List<Cliente> Clientes 
        { 
           get{return _clientes;} 
           set{_clientes = value;} 
        }

        public ListaClientes(string nome, string endereco, string telefone)
        {
            Clientes.Add(new Cliente(nome, endereco, telefone));
        }

        
    }
}