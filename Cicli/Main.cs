using System;

namespace Cicli
{

	
	class MainClass
	{
		static int assegna() { Console.WriteLine("assegna "); return 0; }

		static bool test() { Console.WriteLine("test "); return true; }
		
		static void passo() { Console.WriteLine("passo "); }
		
		public static void Main (string[] args)
		{
            Console.WriteLine("\nforspy");
            for (int i = assegna(); test() && i < 5; ++i, passo())
                Console.WriteLine(i);

            Console.Write("for: ");
			for (int i = 1; i <= 10; ++i)
			{
				Console.Write(i + " ");
			}
	
			Console.Write("\nwhile: ");
			int j = 1;
			while (j <= 10)
			{
				Console.Write(j + " ");
				j++;
			}
			
			Console.Write("\ndo-while: ");
			int k = 1;
			do
			{
				Console.Write(k + " ");
				k++;
			}
			while (k <= 10);
			
			Console.Write("\nforeach: ");
			int[] dati = new int[]{1,1,2,3,4,5,6,7,8,10};
			foreach(int i in dati)
			{
				Console.Write(i + " ");
			}
		}
	}
}

