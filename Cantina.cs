using System;
using Cantina.Produtos;

namespace Cantina{
    public class Cantina{
        public string Nome { get; private set; }
        public string Endereco { get; set; }
        public static bool AbrirCantina { get; private set; }

        public Cantina(string nome, string endereco){
            Nome = nome;
            Endereco = endereco;
            AbrirCantina = true;

            Console.WriteLine("Cantina Aberta \n");
        }




    }
}