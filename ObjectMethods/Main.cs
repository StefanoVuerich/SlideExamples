using System;

namespace ObjectMethods
{
	class MainClass
	{
		int Somma(int a, int b)
		{ 
			return a + b; 
		}
		
		void Somma(int a, int b, out int c)
		{
			c = a + b;
		}
		
		int Lunghezza(string s)
		{ 
			int i = s.Length;
			return i; 
		}
		
		void Swap(string as1, string as2)
		{
			string tmp = as1;
			as1 = as2;
			as2 = tmp; 
		}
		
		void ReferenceSwap(ref string s1, ref string s2)
		{
			string tmp = s1;
			s1 = s2;
			s2 = tmp; 
		}
		
		public static void Main (string[] args)
		{
			MainClass a = new MainClass();
			int r1 = a.Somma(5, 2);
			Console.WriteLine("r1: {0}", r1);
			
			int r2;
			a.Somma(5, 2, out r2);
			Console.WriteLine("r2: {0}", r2);
			
			string s1 = "io sono s2";
			int r3 = a.Lunghezza(s1);
			Console.WriteLine("Lunghezza stringa \"{0}\" è {1}", s1, r3);
			
			string s2 = "io sono s1";
			a.Swap(s1, s2);
			Console.WriteLine("s1: {0} s2: {1}", s1, s2);


			a.ReferenceSwap(ref s1, ref s2);
			Console.WriteLine("s1: {0} s2: {1}", s1, s2);
		}
	}
}

