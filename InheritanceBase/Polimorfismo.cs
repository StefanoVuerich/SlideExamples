using System;

namespace InheritanceBasePolimorfismo
{
	class Persona
	{	
		public Persona(string name, string surname)
		{
			Name = name;
			Surname = surname;
		}
		
		private string name;
		public string Name { get { return name; } set { name = value;}}
		
		private string surname;
		public string Surname { get { return surname; } set { surname = value;}}
		
		virtual public string GetString()
		{
			return Surname + " " + Name;
		}
		
	}
	
	class Lavoratore : Persona 
	{
		public Lavoratore(string name, string surname, string job)
			: base(name, surname)
		{
			Job = job;
		}
		
		private string job;
		public string Job { get { return job; } set { job = value;}}
		
		override public string GetString()
		{
			return base.GetString() + " " + Job;
		}
		
	}
	
	
	public class MyClass 
	{
		public static void MainPolimorfismo(String[] args) 
		{
			Lavoratore lav = new Lavoratore("Mario", "Rossi", "programmatore");
			Persona per = lav;
			Console.WriteLine(per.GetString());
		}
	}
}

