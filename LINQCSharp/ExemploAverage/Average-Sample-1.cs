using System;
using System.Linq;

namespace ExemploAverage
{
    public static partial class Sample1
    {

        /// <summary>
        /// Esta amostra usa Average para obter a média de todos os números em uma matriz.
        /// 
        /// saída
        ///     O número médio é 4.5
        /// </summary>
        public static void MethodSyntaxExample()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            double averageNum = numbers.Average();

            Console.WriteLine($"O número médio é {averageNum}.");
        }

    }
}