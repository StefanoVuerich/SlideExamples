using System;

namespace Using
{
	class MyDispose : IDisposable
	{
		public MyDispose() { Console.WriteLine("MyDispose Build"); }
		
		public void SayHello() 
		{ 
			//throw new Exception("MyDispose Hello Exception");
			Console.WriteLine("MyDispose Hello"); 
		}
		
		public void Dispose()
		{
			Console.WriteLine("MyDispose Disposed");
		}
	
	}
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			using(MyDispose myA = new MyDispose())
			{
				myA.SayHello();
			}
			
			//equivale a:
			MyDispose myB = new MyDispose();
			try
			{
				myB.SayHello();
			}
			finally
			{
				myB.Dispose();
			}
				
		}
	}
}

