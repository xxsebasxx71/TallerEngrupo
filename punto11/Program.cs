using System;

namespace punto11
{
	class Program
	{
		public static void Main(string[] args)
		{
			int cantidad,contador=1,num,par=0,impar=0;
			Console.WriteLine("cuantos numeros va a ingresar");
			cantidad=int.Parse(Console.ReadLine());
			
			while(contador<=cantidad){
				Console.WriteLine("digite el numero");
				num=int.Parse(Console.ReadLine());
				if(num%2==0){
					Console.WriteLine("es par");
					par+=1;
					
				}else{
					Console.WriteLine("es impar");
					impar+=1;
				}
				contador++;
			
			}
			Console.WriteLine("numeros pares: "+par);
			Console.WriteLine("numeros impares: "+impar);	
		
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}