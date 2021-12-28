using System.Collections.Generic;

namespace Cantina.Produtos
{
    public static class Menu
    {
        public static List<Produto> ItemQuentinha = new List<Produto>();

        static Menu()
        {
            /*AddQuentinha("prato Feito", 13);
            AddQuentinha("Simples", 9.99);
            AddQuentinha("Grande", 18);*/           

        }

        public static void AddQuentinha(string quentinha, double valor)
        {
            ItemQuentinha.Add(new Quentinha(quentinha, valor));
        }
    }
}