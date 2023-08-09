using System.Linq;
using System;

namespace ExemploAggregate
{
    public static class Sample1
    {
        
        /// <summary>
        /// 
        /// Este exemplo usa Aggregate para multiplicar os números em execução na matriz.
        /// Multiplicação de todos os números: 88.33081
        /// 
        /// </summary>
        public static void MethodSyntaxExample() 
        { 
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 }; 
            
            double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);


            Console.WriteLine("Este exemplo usa Aggregate para multiplicar \nos números em execução na matriz.");
            Console.WriteLine("");
            Console.WriteLine($"Multiplicação de todos os números: {product}");

            

        }
    }
}
