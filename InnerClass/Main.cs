using System;

namespace InnerClass
{
	
	
	class Car
	{
		private string model;
		public string Model {get{ return model;} set { model = value;} }
		
		public class Engine
		{
			private int cv;
			public int CV {get { return cv;}  set{ cv = value; }}
			
			public void Show()
			{
				Console.WriteLine("{0} ", CV);
				
			}
		}
			
		
	}
	
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			Car.Engine eng = new Car.Engine();
			eng.CV = 10;
			eng.Show();
			
		}
	}
}

