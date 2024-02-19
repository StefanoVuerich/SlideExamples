using System;

namespace ReturnMySelf
{
	class MainClass
	{
		int i = 0;
		
		MainClass() { i = 10; }
		
		MainClass Inc()
		{
			i++;
			return this;
		}
		
		void Print()
		{
			Console.WriteLine("i={0}", i);
		}
		
		public static void Main (string[] args)
		{
			MainClass m = new MainClass();
			m.Inc().Inc().Inc().Print();
		}
	}
}

