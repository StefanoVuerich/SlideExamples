using System;

namespace ObjectFields
{
	class Address
	{
		public string via;
		public int numerocivico;
		public string localita;
		
		public void Stampa()
		{
			Console.WriteLine("via {0} n.{1}, {2}", via, numerocivico, localita);
		}
	}
	
	
	class MainClass
	{
		public int indice;
		public Address indirizzo;
		
		public void Stampa()
		{
			Console.WriteLine("Indice {0}", indice);
			indirizzo.Stampa();
		}
		
		public static void Main (string[] args)
		{
			MainClass myclass = new MainClass();
			myclass.indice = 10;
			
			Address address = new Address();
			address.via = "Vascello";
			address.numerocivico = 1;
			address.localita = "Udine";
			
			myclass.indirizzo = address;
			
			myclass.Stampa();
			
		}
	}
}

