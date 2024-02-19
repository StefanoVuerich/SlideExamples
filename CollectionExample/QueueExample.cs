using System;
using System.Collections.Generic;
namespace CollectionExample
{
	public class QueueExample
	{
		public static void QueueExampleMain (string[] args)
		{
			Queue<Person> people = new Queue<Person>();
			people.Enqueue(new Person("AAA"));
			people.Enqueue(new Person("BBB"));
			
			
			Person firstPerson = people.Peek();
			Console.WriteLine("PEEK {0}", firstPerson);
			
			try
			{
				while(true)
				{
					Person p = people.Dequeue();
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

