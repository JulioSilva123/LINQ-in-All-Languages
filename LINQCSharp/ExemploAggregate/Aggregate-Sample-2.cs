using System.Linq;
using System;

namespace ExemploAggregate
{
	public static class Sample2
	{

        /// <summary>
        /// Este exemplo usa Aggregate para criar um saldo de conta corrente 
		/// que subtrai cada retirada do saldo inicial de 100, desde que o 
		/// saldo nunca caia abaixo de 0.
		/// 
		/// Saída:
		/// 
		/// Balanço final: 20
        /// </summary>
        public static void MethodSyntaxExample() 
		{ 
			double startBalance = 100.0; 

			int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 }; 

			double endBalance = 
				attemptedWithdrawals.Aggregate(startBalance, 
				(balance, nextWithdrawal) => 
				((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

			Console.WriteLine($"Este exemplo usa Aggregate para criar um saldo \nde conta corrente que subtrai cada retirada do \nsaldo inicial de 100, desde que o saldo nunca \ncaia abaixo de 0.");
            Console.WriteLine("");
            Console.WriteLine($"Balanço final: {endBalance}"); 
		 }
	}
}