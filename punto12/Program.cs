/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 19/09/2019
 * Time: 7:22 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto12
{
	class Program
	{
		public static void Main(string[] args)
		{
			long mult=1;
			for(int i=10;i<=20; i++){
				mult=mult*i;
			}
			Console.WriteLine(mult);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}