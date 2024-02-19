using System;
using System.Collections.Generic;
namespace CollectionExample
{
	public class SortedDictionaryExample
	{
		public static void SortedDictionaryExampleMain (string[] args)
		{
			SortedDictionary<PersonOrdered, Company> people = new SortedDictionary<PersonOrdered, Company>();
			
			PersonOrdered aaa = new PersonOrdered("aaa", "Anome", "ACognome");
			PersonOrdered bbb= new PersonOrdered("bbb", "Bnome", "BCognome");
			PersonOrdered zzz = new PersonOrdered("zzz", "Znome", "ZCognome");
			PersonOrdered ccc = new PersonOrdered("ccc", "Cnome", "CCognome");
			
			Company c1 = new Company("c1");
			Company c2 = new Company("c2");
			
			people.Add(aaa, c1);
			people.Add(bbb, c1);
			//people.Add(zzz, c1); //ERROR: no duplicate keys allowed
			//people.Add(new Person("zzz"), c1); //ERROR: no duplicate keys allowed
			people.Add(zzz, c1);
			people.Add(ccc, c2);
			
			PersonOrdered bbblike = new PersonOrdered("bbb");
			
			bool b = people.ContainsKey(bbblike);
			Console.WriteLine("People contains bbblike= {0}", b);
			
			//key exist, try/catch useless
			try
			{
				Company bbbcompany = people[bbblike];
				Console.WriteLine(bbbcompany);
			}
			catch(Exception e)
			{
				Console.WriteLine(e);
			}

			Console.WriteLine("People List");
			foreach(KeyValuePair<PersonOrdered, Company> kvp in people )
			{
			    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
			}
			
			Console.WriteLine("Remove");
			people.Remove(new PersonOrdered("aaa"));
			foreach(KeyValuePair<PersonOrdered, Company> kvp in people )
			{
			    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
			}
			
		}
	}
}

