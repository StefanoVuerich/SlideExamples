using System;

namespace PrimoProgramma
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length > 0 && args[0] == "debug")
			{
				Console.WriteLine ("Sono in debug");
			}
			Console.WriteLine ("Hello, World!");
		}
	}
}

