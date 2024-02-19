using System;
using System.Collections.Generic;
namespace CollectionExample
{
	public class DictionaryExample
	{
		public static void DictionaryExampleMain (string[] args)
		{
			Dictionary<Person, Company> people = new Dictionary<Person, Company>();
			
			Person aaa = new Person("aaa", "Anome", "ACognome");
			Person bbb= new Person("bbb", "Bnome", "BCognome");
			Person zzz = new Person("zzz", "Znome", "ZCognome");
			Person ccc = new Person("ccc", "Cnome", "CCognome");
			
			Company c1 = new Company("c1");
			Company c2 = new Company("c2");
			
			people.Add(aaa, c1);
			//people[aaa] = c1;
			people.Add(bbb, c1);
			//people.Add(zzz, c1); //ERROR: no duplicate keys allowed
			//people.Add(new Person("zzz"), c1); //ERROR: no duplicate keys allowed
			people.Add(zzz, c1);
			people.Add(ccc, c2);
			
			Person bbblike = new Person("bbb");
			
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
			foreach(KeyValuePair<Person, Company> kvp in people )
			{
			    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
			}
			
			Console.WriteLine("Remove");
			people.Remove(new Person("aaa"));
			foreach(KeyValuePair<Person, Company> kvp in people )
			{
			    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
			}
			
		}
	}
}

