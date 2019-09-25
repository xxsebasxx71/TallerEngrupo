using System;

namespace punto15
{
	class Program
	{
		public static void Main(string[] args)
		{
			//sus errores son definir las variable a,x,b,y
			//y falta el incremento en los ciclos
			while (x<1 && x>10){
				a=b;
			}
			
			while(a==b)/*;*/
			{
				a=b;
				x=y;
			
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}