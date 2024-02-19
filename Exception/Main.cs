using System;

namespace ExceptionExample
{
	public class MyException : ApplicationException
	{
		public MyException ()
		{
		}
		
		public MyException (string message) : base (message)
		{
		}

		public MyException (string message, Exception inner) : base (message, inner)
		{
		}
	}
	
	class MainClass
	{
		private bool throwMyException;
		
		private void G()
		{
			Console.WriteLine("G call");
			if (throwMyException)
			{
				throw new MyException("G() exception");
			}
			Console.WriteLine("G return");
		}
		
		private void F()
		{
			Console.WriteLine("F call");
			G();
			Console.WriteLine("F return");
		}
		
		public static void Main (string[] args)
		{
			MainClass main = new MainClass();
			//main = null; //this will throw Exception
			try
			{
				main.throwMyException = true;
				//main.ithrow = false;
				main.F();
			}
			catch(MyException e)
			{
				Console.WriteLine("MyException throw {0}", e.Message);
			}
			catch(Exception e)
			{
				Console.WriteLine("Exception throw {0}", e.Message);
			}
			finally
			{
				Console.WriteLine("Here always");
			}

		}
	}
}

