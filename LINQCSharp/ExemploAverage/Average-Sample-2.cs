using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemploAverage
{
    public static class Sample2
    {


        /// <summary>
        /// Esta amostra usa Average para obter o comprimento médio das palavras na matriz.
        /// 
        /// Saídas:
        /// O comprimento médio da palavra é 6,66666666666667 caracteres.
        /// </summary>
        public static void MethodSyntaxExample()
        {
            string[] words = { "cereja", "maçã", "laranja" };

            double averageLength = words.Average(w => w.Length);

            Console.WriteLine($"O comprimento médio da palavra é {averageLength} caracteres.");
        }

    }

}