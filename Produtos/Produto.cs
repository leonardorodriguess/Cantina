namespace Cantina.Produtos
{
    public abstract class Produto
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public string Descricao { get; set; }
        private int _quantidade = 1;
        public int Quantidade 
        { 
            get {return _quantidade;}
            set {_quantidade = value;} 
        }

        //construtor
        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;       
        }

    }
}