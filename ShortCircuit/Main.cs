using System;

namespace ShortCircuit
{
	class MainClass
	{
		static bool testA(int i) 
		{
			bool b =  i > 10;
			Console.WriteLine("testA is " + b);
			return b;
		}
	
		static bool testB(int i) 
		{
			bool b =  i > 20;
			Console.WriteLine("testB is " + b);
			return b;
		}
	
		static bool testC(int i) 
		{
			bool b = i > 30;
			Console.WriteLine("testC is " + b);
			return b;
		}
			
		public static void Main (string[] args)
		{
			int i = 15;
			bool b = testA(i) & testB(i) & testC(i);

			if(2){
			}

			Console.WriteLine("ALL is " + b);
		}
	}
}

