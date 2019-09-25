using System;

namespace punto17
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//el valor es nulo 
			int sum=0;
			int i=0;
			int j;
			while(i<5){
				j=5;
				while(i !=j){
					sum+=j;
					
					j--;
				}
				i++;
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}