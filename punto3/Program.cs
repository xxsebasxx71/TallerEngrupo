using System;

namespace punto3
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int num;
			double cont;
            Console.Write( "Ingrese un numero"); 
            num=int.Parse(Console. ReadLine()) ; 
            for(int i = 0;i<num;i++) 
            	if(i % 5 ==0)
                  cont++;

            Console.WriteLine(cont);
            
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}