using System;

namespace GarbageCollector
{
	class Draw {
		bool clean = true;
		string mystring;
		
		public Draw(String s) 
		{ 
			mystring = s; 
			DrawIt(); 
		}
		
		public void DrawIt() 
		{ 
			Console.WriteLine(mystring); 
			clean = false; 
		}
		
		public void Clear() 
		{ 
			Console.WriteLine("##" + mystring + "##"); 
			clean = true; 
		}
		
		~Draw() 
		{
			if (!clean) 
				Console.WriteLine("ERRORE!");
		}
	}
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			Draw d1 = new Draw("d1");
			new Draw("d2");
			d1.Clear();
			GC.Collect();
		}
	}
}

