using System;
namespace InheritanceBaseConCostruttore
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
		
		protected string GetString()
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
		
		public string GetString()
		{
			return base.GetString() + " " + Job;
		}
		
	}
	
	
	public class MyClass 
	{
		public static void MainConCostruttore(String[] args) 
		{
			Lavoratore lav = new Lavoratore("Mario", "Rossi", "programmatore");
			Console.WriteLine(lav.GetString());
			lav.Name = "Luca";
			Console.WriteLine(lav.GetString());
		}
	}
}
