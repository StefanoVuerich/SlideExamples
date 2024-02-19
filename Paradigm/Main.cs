using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Paradigm
{
	//used for object oriented
	class MyClass
	{
		int x = 5;
		public void Print() { Console.WriteLine("Object Oriented: x = {0}", x); }
	}
	//end used for object oriented
	
	class MainClass
	{
		//used for functional
		delegate void MessageWriter(string message);
		
		static void DoMessage(MessageWriter theWriter)
		{
			theWriter("Hello!!");
		}
		//end used for functional
		
		public static void Main (string[] args)
		{
			//imperative
			int x = 0;
			x = x + 1;
			Console.WriteLine("Imperative: x = {0}", x);
			
			//object oriented
			MyClass myObject = new MyClass();
			myObject.Print();
			
			//generic
			List<string> ls = new List<string>();
			ls.Add("a");
			ls.Add("b");
			ls.Add("c");
			
			StringBuilder sb = new StringBuilder();
			foreach(string s in ls)
				sb.Append(s);
			Console.WriteLine("Generic: sb = {0}", sb.ToString());
			
			//declarative
			string[] data = { "a", "bar", "motore", "auto" };
            IEnumerable<string> result = from g in data where g.Length > 4 select g;
            Console.WriteLine(result.ElementAt(0));
			
			//functional
			DoMessage(msg => {Console.WriteLine("Functional: msg={0}", msg); }); 
		}
	}
}

