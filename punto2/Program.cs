/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 23/09/2019
 * Time: 3:11 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num;
			Console.WriteLine("digite un numero");
			num=int.Parse(Console.ReadLine());
			for(int i=1; i<num + 1;i++)
				Console.WriteLine("los numeros del 1 hasta el "+num+" es: "+i);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}