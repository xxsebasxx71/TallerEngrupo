/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 24/09/2019
 * Time: 7:04 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int cantidad,peso;
            int superior=0,inferior=0;
            
            Console.WriteLine("Cantidad de personas");
            cantidad= int.Parse(Console.ReadLine());
            
            for(int i=1; i <= cantidad; i++){
                Console.WriteLine("Ingresar peso: "+i);
                peso= int.Parse(Console.ReadLine());
                
                
                if(peso>=80){
                    superior++;
                }else
                    inferior++;
            }
            Console.WriteLine("Mayor a 80kg: "+ superior);
            Console.WriteLine("Menor a 80kg: "+ inferior);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}