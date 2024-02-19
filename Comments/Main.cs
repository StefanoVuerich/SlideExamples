using System;

namespace Comments
{
	/// <summary>
	/// Classe Base
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// Somma due interi
		/// </summary>
		/// <param name="a">primo valore</param>
		/// <param name="b">secodo valore</param>
		/// <returns>risultato</returns>
		int Somma(int a, int b)
		{ 
			return a + b; 
		}
		

		bool Contenuta(DateTime da, DateTime a, DateTime confronto)
		{
			
		}
		
		void Somma(int a, int b, out int c)
		{
			c = a + b;
		}
		
		/// <summary>
		/// Restituisce la lunghezza della stringa
		/// </summary>
		/// <param name="s">stringa</param>
		/// <returns>lunghezza</returns>
		int Lunghezza(string s)
		{ 
			int i = s.Length;
			return i; 
		}
		
		/// <summary>
		/// Tenta di invertire le due stringhe
		/// </summary>
		/// <param name="s1">prima stringa</param>
		/// <param name="s2">seconda stringa</param>
		void Swap(string s1, string s2)
		{
			string tmp = s1;
			s1 = s2;
			s2 = tmp; 
		}
		
		/// <summary>
		/// Inverte le due stringhe
		/// </summary>
		/// <param name="s1">prima stringa</param>
		/// <param name="s2">seconda stringa</param>
		void ReferenceSwap(ref string s1, ref string s2)
		{
			string tmp = s1;
			s1 = s2;
			s2 = tmp; 
		}
		
		/// <summary>
		/// Da dove tutto inizia
		/// </summary>Parametri di avvio</param>
		public static void Main (string[] args)
		{
			MainClass a = new MainClass();
			int r1 = a.Somma(5, 2);
			Console.WriteLine("r1: {0}", r1);
			
			int r2;
			a.Somma(5, 2, out r2);
			Console.WriteLine("r2: {0}", r2);
			
			string s1 = "io sono s2";
			int r3 = a.Lunghezza(s1);
			Console.WriteLine("Lunghezza stringa \"{0}\" è {1}", s1, r3);
			
			string s2 = "io sono s1";
			a.Swap(s1, s2);
			Console.WriteLine("s1: {0} s2: {1}", s1, s2);
			
			a.ReferenceSwap(ref s1, ref s2);
			Console.WriteLine("s1: {0} s2: {1}", s1, s2);
		}
	}
}

