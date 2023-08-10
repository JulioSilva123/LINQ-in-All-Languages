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






        ///// <summary>
        ///// Este exemplo usa Aggregate para multiplicar os números em execução na matriz.
        ///// 
        ///// Saída:
        /////     Multiplicação de todos os números 88.33081
        ///// </summary>
        //public static void MethodSyntaxExample()
        //{
        //    double[] doubles = new[] { 1.7d, 2.3d, 1.9d, 4.1d, 2.9d };

        //    // Dim product = doubles.Aggregate(Function(runningProduct, nextFactor) runningProduct * nextFactor)
        //    double product = doubles.Aggregate((runningProduct, nextFactor) => Agregar(runningProduct, nextFactor));

        //    Console.WriteLine($"Multiplicação de todos os números: {product}");
        //}


        //public static double Agregar(object runningProduct, object nextFactor)
        //{

        //    Console.WriteLine("runningProduct = " + runningProduct.ToString());
        //    Console.WriteLine("nextFactor = " + nextFactor.ToString());
        //    Console.WriteLine("runningProduct * nextFactor = " + Operators.MultiplyObject(runningProduct, nextFactor).ToString());
        //    Console.WriteLine("");

        //    return Conversions.ToDouble(Operators.MultiplyObject(runningProduct, nextFactor));

        //}




    }
}
