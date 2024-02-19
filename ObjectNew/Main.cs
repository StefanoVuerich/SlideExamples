using System;
using System.Text;

namespace ObjectNew
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StringBuilder s1 = new StringBuilder("Ciao");
			StringBuilder s2 = new StringBuilder("hello");
			double i = 10;	
			double j = 20;
			
			s1 = s2;
			s1.Replace('h', 'H');
			
			i = j;
			i /= 2;
			
			Console.WriteLine("s1 {0}", s1);
			Console.WriteLine("s2 {0}", s2);
			Console.WriteLine("i {0}", i);
			Console.WriteLine("j {0}", j);
		}
	}
}

