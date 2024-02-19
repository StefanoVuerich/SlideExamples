using System;
using System.Collections.Generic;
namespace CollectionExample
{
	public class ListExample
	{
		public static void ListExampleMain (string[] args)
		{
			List<Person> people = new List<Person>();
			
			Console.WriteLine("Example 1");
			Person p1 = new Person("xxx");
			p1.Name = "N1";
			p1.Surname = "N2";
			people.Add(p1);
			
			people.Insert(1, new Person("yyy"));
			
			foreach(Person p in people)
			{
				Console.WriteLine(p);
			}
			Console.WriteLine("END Example 1");
			
			Console.WriteLine("Example 2");
			p1.Surname = "New N2";
			people.Insert(1, p1);
			foreach(Person p in people)
			{
				Console.WriteLine(p);
			}
			Console.WriteLine("END Example 2");
			
			Console.WriteLine("Example 3");
			people.AddRange(new Person[]{new Person("zzz", "Zuzz", "Zugl"), new Person("kkk")});
			
			Person zzz = people[3];
			Console.WriteLine(zzz);
			
			people.RemoveAt(3);
			Console.WriteLine(people[3]);
			Console.WriteLine("END Example 3");
			
			Console.WriteLine("Example 4");
			
			people.Clear();
			Person gigi = new Person("ggg", "Gigi", "S");
			people.Add(gigi);
			Person toni = new Person("ttt", "Toni", "T");
			people.Add(toni);
			
			Person reftoGigi = gigi;
			
			Person likeGigi = new Person("ggg", "Gigi", "S");
			
			bool containsref = people.Contains(reftoGigi);
			bool containslike = people.Contains(likeGigi);
			Console.WriteLine("ref?{0}, like?{1}", containsref, containslike);

			int idx = people.IndexOf(likeGigi);
			Console.WriteLine("Index: {0}", idx);
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

