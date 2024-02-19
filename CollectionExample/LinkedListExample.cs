using System;
using System.Collections.Generic;
namespace CollectionExample
{
	public class LinkedListExample
	{
		public static void LinkedListExampleMain (string[] args)
		{
			LinkedList<Person> people = new LinkedList<Person>();
			
			Console.WriteLine("Example 1");
			Person p1 = new Person("xxx");
			p1.Name = "N1";
			p1.Surname = "N2";
			LinkedListNode<Person> p1Node = people.AddFirst(p1);
			
			people.AddAfter(p1Node, new Person("yyy"));
			
			foreach(Person p in people)
			{
				Console.WriteLine(p);
			}
			Console.WriteLine("END Example 1");
			
			Console.WriteLine("Example 2");
			p1.Surname = "New N2";
			people.AddAfter(p1Node, p1);
			foreach(Person p in people)
			{
				Console.WriteLine(p);
			}
			Console.WriteLine("END Example 2");
			
			Console.WriteLine("Example 3");
			LinkedListNode<Person> zzzNode = people.AddLast(new Person("zzz", "Zuzz", "Zugl"));
			people.AddLast(new Person("kkk"));
			
			foreach(Person p in people)
			{
				Console.WriteLine(p);
			}
			
			Console.WriteLine("Remove");
			people.Remove(zzzNode);
			
			foreach(Person p in people)
			{
				Console.WriteLine(p);
			}
			
			Console.WriteLine("END Example 3");
			
			Console.WriteLine("Example 4");
			
			people.Clear();
			Person gigi = new Person("ggg", "Gigi", "S");
			people.AddLast(gigi);
			Person toni = new Person("ttt", "Toni", "T");
			people.AddLast(toni);
			
			Person reftoGigi = gigi;
			
			Person likeGigi = new Person("ggg", "Gigi", "S");
			
			bool containsref = people.Contains(reftoGigi);
			bool containslike = people.Contains(likeGigi);
			Console.WriteLine("ref?{0}, like?{1}", containsref, containslike);

			Console.WriteLine("END Example 4");
			
			Console.WriteLine("Example 5");
			people.Remove(likeGigi);
			foreach(Person p in people)
			{
				Console.WriteLine(p);
			}
			Console.WriteLine("END Example 5");
		}	
	}
}

