using System.Collections.Generic;

namespace Cantina.Produtos
{
    public class Menu
    {
        public List<Produto> ItemQuentinha = new List<Produto>();

        public Menu()
        {
            AddQuentinha("prato Feito", 13);
            AddQuentinha("Simples", 9.99);
            AddQuentinha("Grande", 18);           

        }

        private void AddQuentinha(string quentinha, double valor)
        {
            ItemQuentinha.Add(new Quentinha(quentinha, valor));
        }
    }
}