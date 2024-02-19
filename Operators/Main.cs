using System;

namespace Operators
{
	class MyClass
	{
		public int i;
	}
	
	struct MyStruct
	{
		public int i;
	}
	
	
	class MainClass
	{
		static void assignment()
		{
			MyClass c1 = new MyClass();
			c1.i = 10;
			MyClass c2 = c1;
			c2.i++;
			
			MyStruct s1 = new MyStruct();
			s1.i = 5;
			MyStruct s2 = s1;
			s2.i++;
			
			Console.WriteLine("c1.i {0} c2.i {1} s1.i {2} s2.i {3}", c1.i, c2.i, s1.i, s2.i);
		}
		
		static void method(int i)
		{
			Console.WriteLine("i:{0}", i);
		}
		
		static void autoincdec()
		{
			int i = 0;
			method(i);
			method(i++);
			method(i);
			method(++i);
			method(i);
		}
		
		public static void Main (string[] args)
		{
			assignment();
			autoincdec();
		}
	}
}

