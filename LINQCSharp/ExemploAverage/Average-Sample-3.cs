using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemploAverage
{
    

    public static class Sample3
    {



        // Este exemplo usa a sintaxe Average e query para obter o preço médio dos produtos de cada categoria.


        /// <summary>
        /// Este exemplo usa a sintaxe Average e query para obter o preço médio dos produtos de cada categoria.
        /// 
        /// Saída:
        /// 
        /// 
        /// </summary>
        public static void QuerySyntaxExample()
        {
            List<Produto> produtos = Data.Produtos;

            var categories =
                from prod in produtos
                group prod by prod.Category into prodGroup
                select new { CategoryName = prodGroup.Key, AveragePrice = prodGroup.Average(p => p.UnitPrice) };

            foreach (var category in categories)
            {
                Console.WriteLine($"O preço médio de um produto da categoria {category.CategoryName} é de {category.AveragePrice:C}.");
            }

        }



        // Este exemplo usa a sintaxe Average e de método para obter o preço médio dos produtos de cada categoria.


        /// <summary>
        /// Este exemplo usa a sintaxe Average e de método para obter o preço médio dos produtos de cada categoria.
        /// 
        /// Saída:
        /// 
        /// </summary>
        public static void MethodSyntaxExample()
        {
            List<Produto> produtos = Data.Produtos;

            var categories =
                produtos.GroupBy(prod => prod.Category)
                    .Select(
                        prodGroup => new {CategoryName = prodGroup.Key, AveragePrice = prodGroup.Average(p => p.UnitPrice)});

            foreach (var category in categories)
            {
                Console.WriteLine($"O preço médio de um produto da categoria {category.CategoryName} é de {category.AveragePrice:C}.");
            }
        }
    }
}