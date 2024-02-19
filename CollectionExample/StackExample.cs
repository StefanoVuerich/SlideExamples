using System;
using System.Collections.Generic;
namespace CollectionExample
{
	public class StackExample
	{
		public static void StackExampleMain (string[] args)
		{
			Stack<Person> people = new Stack<Person>();
			people.Push(new Person("AAA"));
			people.Push(new Person("BBB"));
			
			
			Person lastPerson = people.Peek();
			Console.WriteLine("PEEK {0}", lastPerson);
			
			try
			{
				while(true)
				{
					Person p = people.Pop();
					Console.WriteLine(p);
				}
			}
			catch(InvalidOperationException e)
			{
				Console.WriteLine("this is the end: {0}", e.Message);
			}
						
		}
	}
}

