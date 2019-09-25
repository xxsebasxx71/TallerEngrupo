/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 24/09/2019
 * Time: 7:06 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto9
{
	class Program
	{
		public static void Main(string[] args)
		{
			double num,acomulador=0;
			int i=1;
			
			while(i<=5){
				Console.WriteLine("Ingresar numero "+i);
				num=double.Parse(Console.ReadLine());
				i++;
				
				acomulador=acomulador+num;
			}
			Console.WriteLine("Promedio: "+(acomulador/5));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}