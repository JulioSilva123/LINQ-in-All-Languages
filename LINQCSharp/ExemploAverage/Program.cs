using ExemploAverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Exemplos da Função Average \n\n");

            Sample1.MethodSyntaxExample();
            Console.WriteLine("\n-------\n");
            Sample2.MethodSyntaxExample();
            Console.WriteLine("\n-------\n");
            Sample3.QuerySyntaxExample();
            Console.WriteLine("\n-------\n");
            Sample3.MethodSyntaxExample();
            

            Console.ReadKey();

        }
    }
}
