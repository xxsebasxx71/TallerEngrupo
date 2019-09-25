using System;

namespace punto10
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num, mayores=0, menores=0;
			
			for (int i = 1; i <= 10; i++) {
				Console.WriteLine("Ingresar numero "+i);
				num=int.Parse(Console.ReadLine());
				
				if(num>0){
					mayores++;
				}else if(num<0){
					menores++;
				}else
					Console.WriteLine("El numero es 0");
			}
			Console.WriteLine("Cantidad de numeros mayores a 0: "+mayores);
			Console.WriteLine("Cantidad de numeros menores a 0: "+menores);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}