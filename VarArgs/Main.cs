using System;

namespace VarArgs
{
	class MainClass
	{
		
		static int Sum(params int[] items)
		{
			int sum = 0;
	
			foreach(int i in items)
			{
				sum += i;
			}
			
			return sum;
		}

		
		public static void Main (string[] args)
		{
			int result = Sum(1, 7, 4);
			Console.WriteLine ("Result = {0}", result);
		}
	}
}

