using System;

namespace EnumTypeValue
{
	public enum Misure { XS, S, M, L, XL }

	public class MyClass 
	{
		
		static void check(Misure m) {
			
			switch(m) 
			{ 
				case Misure.XS: Console.WriteLine("Piccolissimo"); break;
				case Misure.XL: Console.WriteLine("Grandissimo"); break;
				default: Console.WriteLine("OK"); break;
			}
		}
			
		public static void Main(String[] args) 
		{
			
			Enum.GetValues(typeof(Misure));			
			foreach(Misure misure in Enum.GetValues(typeof(Misure)))
				Console.WriteLine("Valori:{0} Id:{1}", misure, (int)misure);
	
			Misure m = Misure.XS;
			check(m);
		}
	}
}

