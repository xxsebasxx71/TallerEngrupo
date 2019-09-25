using System;

namespace punto16
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*int i=1,contador=0;
			while(i<100){
				
				contador+=i;
				i++;
							
			}
			Console.WriteLine(contador);*/
			
			int i=1,contador=0;
			while(i<=50){
				
				contador+=5;
				i++;
							
			}
			Console.WriteLine(contador);
		
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}