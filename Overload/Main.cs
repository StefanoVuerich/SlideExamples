using System;

namespace Overload
{
	
	class MainClass
	{
		public static double Add(double a, double b)
		{
			Console.WriteLine("Add double");
			return a + b;
		}
		
		public static int Add(int a, int b)
		{
			Console.WriteLine("Add int");
			return a + b;
		}
		
		
		public static void Main (string[] args)
		{
			Console.WriteLine(Add(5.1, 2.2));
			Console.WriteLine(Add(5, 2));
		}
	}
}

