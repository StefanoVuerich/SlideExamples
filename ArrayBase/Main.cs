using System;

namespace ArrayBase
{
	class MainClass
	{
		int i;
		
		public static void Main (string[] args)
		{
			int[] ints = new int[3];
			ints[2] = 10;
			
			MainClass[] mainClasses = new MainClass[3];
			MainClass mc = new MainClass();
			mc.i = 5;
			mainClasses[0] = mc;
			mainClasses[1] = new MainClass();
			mainClasses[1].i = 2;
			
			string[] strings = new string[] {"ciao", "a", "tutti"};
			strings[0] = "ciao";
			strings[1] = "a";
			strings[2] = "tutti";
			
			Console.WriteLine("ints[1]={0} mainClasses[1].i={1} strings[0]={2}", ints[1], mainClasses[1].i, strings[0]);
			
		}
	}
}

