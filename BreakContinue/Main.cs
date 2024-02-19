using System;

namespace BreakContinue
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i = 0; i < 100; i++)
			{
			
			if (i == 20)
				break;

			if ((i % 5) == 0)
			{
				Console.WriteLine();
				continue;
			}
			Console.WriteLine(i + " ");
			}
		}
	}
}

