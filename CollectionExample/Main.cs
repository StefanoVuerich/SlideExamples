using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CollectionExample
{
	class Person
	{
		public Person(string cf)
			: this(cf, "Unknown", "Unknown")
		{ }
		
		public Person(string cf, string name, string surname)
		{
			CF = cf; Name = name; Surname = surname;
		}
		
		public string CF { get; set; }
		
		public string Name { get; set; }
		
		public string Surname { get; set; }
		
		override public string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("CF:{0} Name:{1} Surname:{2}", CF, Name, Surname);
			return sb.ToString();
		}
		
		/* for list/linked list/stack/queue/dictionary/sorteddictionary */
		public override bool Equals (object obj)
		{
			return CF == ((obj as Person).CF);
		}
		
		/* for dictionary */
		public override int GetHashCode ()
		{
			return CF.GetHashCode ();
		}
		
	}

	class PersonOrdered : Person, IComparable<PersonOrdered>
	{
		public PersonOrdered(string cf)
			: base(cf)
		{ }
		
		public PersonOrdered(string cf, string name, string surname)
			: base(cf, name, surname)
		{
		}
		
		public int CompareTo(PersonOrdered person)
		{
		   if (person == null) 
				return -1;
		 
			return CF.CompareTo(person.CF);
		}
	}
	
	class Company
	{
		public Company(string cf)
			: this(cf, "Unknown")
		{ }
		
		public Company(string cf, string ragionesociale)
		{
			CF = cf; Ragionesociale = ragionesociale;
		}
		
		public string CF { get; set; }
		
		public string Ragionesociale { get; set; }
		
		override public string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("CF:{0} Ragionesociale:{1}", CF, Ragionesociale);
			return sb.ToString();
		}
		
		/* for Contains */
		public override bool Equals (object obj)
		{
			return CF == (obj as Company).CF;
		}
		
		/* for dictionary */
		public override int GetHashCode ()
		{
			return CF.GetHashCode ();
		}
	}
	
	public class CollectionExample
	{
		public static void Main (string[] args)
		{
			//ListExample.ListExampleMain(args);
			//LinkedListExample.LinkedListExampleMain(args);
			//StackExample.StackExampleMain(args);
			//QueueExample.QueueExampleMain(args);
			//DictionaryExample.DictionaryExampleMain(args);
			SortedDictionaryExample.SortedDictionaryExampleMain(args);
		}
	}
	
	
	
}

