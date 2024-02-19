using System;

namespace ThisConstructor
{
	class MyClass
	{
		int j;
		String str;
	
		MyClass(String s, int i)
		{
			j = i;
			str = s;
		}
	
		MyClass(String s) : this(s, 5)
		{
		}
	
		MyClass() : this("ciao", 5)
		{
		}
		
		void print()
		{
			Console.WriteLine(str + " " + j);
		}
			
		public static void Main(String[] args)
		{
			MyClass m = new MyClass();
			m.print();
		}
	}
}

