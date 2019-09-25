using System;

namespace punto4
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num,suma=0,mult=1;
			for(int i=1;i<=10;i++){
				Console.WriteLine("digite el numero "+i);
				num=int.Parse(Console.ReadLine());
				
				if(num>0){
					suma+=num;
				
				}else if(num<0){
					mult=num*mult;
				}else{
					Console.WriteLine("null");
				}
				
			}
			Console.WriteLine("suma de numeros positivos: "+suma);
			Console.WriteLine("multiplicacion de los negativos: "+mult);
				
				
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}