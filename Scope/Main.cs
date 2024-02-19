using System;

namespace Scope
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i = 1;
			double j = 5;
			Console.WriteLine("i={0} j={1}", i, j);
			{
				int k = 20;
				string s = "Ciao";
				Console.WriteLine("i={0} j={1} k={2} s={3}", i, j, k, s);
				i += k;
			}
			Console.WriteLine("i={0} j={1}", i, j);
		}
	}
}

