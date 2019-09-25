/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 24/09/2019
 * Time: 7:05 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num;
            
            Console.WriteLine("Ingresar numero");
            num=int.Parse(Console.ReadLine());
            Console.WriteLine("Tablas de multiplicar de: "+num);
            
            for(int i=1; i<=10; i++){
                
                Console.WriteLine(num+"x"+i+"="+(num*i));
            }
            
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}