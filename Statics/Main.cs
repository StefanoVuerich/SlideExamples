using System;

namespace Statics
{
	class ClassAShow
	{
		static public void Show(ClassA a)
		{
			Console.WriteLine("ClassAShow: i={0} j={1}", ClassA.i, a.j);
		}
	}
	
	class ClassA
	{
		public static int i = 0;
		public int j = 0;
		
		public void increase()
		{
			i++;
			j++;
		}
		
		public void Show()
		{
			Console.WriteLine("ClassA: i={0} j={1}", i, j);
		}
		
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			ClassA a1 = new ClassA();
			ClassA a2 = new ClassA();
			a1.increase();
			a2.increase();
			
			a1.Show();
			a2.Show();
			
			ClassAShow.Show(a1);
			ClassAShow.Show(a2);
			
		}
	}
}

