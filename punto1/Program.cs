
using System;

namespace punto1
{
	class Program
	{
		public static void Main(string[] args)
		{
			double suma=0; 
			int num;
            Console.WriteLine("Digite un numero"); 
            num=int.Parse(Console.ReadLine());
            for (int i=0; i < num; i++) 
            	suma=suma+i;
            	Console.WriteLine("la suma de los números que anteceden a "+ num+" es:"+ suma);


			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}


