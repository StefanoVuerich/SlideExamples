using System;

namespace Esempi
{
	class Punto
	{
		public int x;
		public int y;
		
		public Punto Sum(Punto p)
		{
			
		}
		
		public double Distanza(Punto p)
		{
			
		}
	}
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			Punto p1 = new Punto();
			p1.x=5; p1.y = 10;
			Punto p2 = new Punto();
			p2.x=15; p2.y = 20;
			
			double d = p1.Distanza(p2);
		}
	}
	
	
	
}

