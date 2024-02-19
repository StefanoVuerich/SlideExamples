using System;

namespace InheritanceBase
{
	class Persona
	{	
		private string name;
		public string Name { get { return name; } set { name = value;}}
		
		private string surname;
		public string Surname { get { return surname; } set { surname = value;}}
		
		public virtual string GetString()
		{
			return Surname + " " + Name;
		}
		
	}
	
	class Lavoratore : Persona 
	{
		private string job;
		public string Job { get { return job; } set { job = value;}}
		
		public override string GetString()
		{
			return base.GetString() + " " + Job;
		}
		
	}
	
	
	public class MyClass 
	{
		public static void MainBase(String[] args) 
		{
		
			Persona p = new Persona();
			p.Name = "Mario";
			p.Surname = "Rossi";
			Console.WriteLine(p.GetString());
			
			Lavoratore l = new Lavoratore();
			l.Name = "Mario";
			l.Surname = "Biachi";
			l.Job = "Sviluppatore Software";
			Console.WriteLine(l.GetString());

		}
	}
	
	public class MainClass
	{
		public static void Main(String[] args) 
		{
		
			MyClass.MainBase(args);
			//InheritanceBaseConCostruttore.MyClass.MainConCostruttore(args);
			//InheritanceBasePolimorfismo.MyClass.MainPolimorfismo(args);

			Console.ReadKey();

		}
	}
}


