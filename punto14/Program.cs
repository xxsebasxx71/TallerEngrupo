using System;

namespace punto14
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			for (int i=1;i<=20;i++){
				for(int j=1;j<=i;j++){
					Console.Write(j);
				}
				Console.WriteLine("");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}