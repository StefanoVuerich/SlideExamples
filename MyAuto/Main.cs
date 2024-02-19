using System;

namespace MyAuto
{
	class Conducente
	{
		public string Cognome { get; set; }
		public string Nome { get; set; }
	}
	
	class Veicolo
	{
		public string Modello{ get; set; }
		public Conducente Conducente{ get; set; }
	}
	
	class Macchina : Veicolo
	{
		
		private Motore motore;
		private Ruota[] ruoteAnteriori;
		private Ruota[] ruotePosteriori;
		
		public Macchina()
		{
			motore = new Motore();
			ruoteAnteriori = new Ruota[2];
			ruotePosteriori = new Ruota[2];
			
			for(int i = 0; i < 2; ++i)
			{
				ruoteAnteriori[i] = new Ruota();
				ruotePosteriori[i] = new Ruota();
			}
						
		}
		
		public void Accendi()
		{
			if (!motore.IsAcceso() && ControlloPressioneOk())
				motore.Accendi();
		}
		
		public void Spegni()
		{
			if (motore.IsAcceso())
				motore.Spegni();
		}
		
		public void ImpostaPressione(double anteriore, double posteriore)
		{
			foreach(Ruota ruota in ruoteAnteriori)
				ruota.Pressione = anteriore;
			
			foreach(Ruota ruota in ruotePosteriori)
				ruota.Pressione = posteriore;
				
		}
		
		private bool ControlloPressioneOk()
		{
			foreach(Ruota ruota in ruoteAnteriori)
				if (ruota.Pressione > Ruota.MASSIMA_PRESSIONE)
					return false;
			
			foreach(Ruota ruota in ruotePosteriori)
				if (ruota.Pressione > Ruota.MASSIMA_PRESSIONE)
					return false;
			
			return true;
		}
	}
	
	class Ruota
	{
		public double Pressione { get; set; }
		public const double MASSIMA_PRESSIONE = 3;
	}
	
	class Motore
	{
		private bool acceso;
		
		public void Accendi()
		{
			acceso = true;
			Console.WriteLine("Accensione Motore");
		}
		
		public void Spegni()
		{
			acceso = false;
			Console.WriteLine("Spegnimento Motore");
		}

		public bool IsAcceso() {  return acceso; }
		
	}
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Conducente tiziano = new Conducente();
			tiziano.Cognome = "Cap";
			tiziano.Nome = "Tiziano";
			
			Macchina fiatuno = new Macchina();
			fiatuno.Conducente = tiziano;
			fiatuno.Modello = "Fiat Uno";
			
			fiatuno.ImpostaPressione(2, 5);
			
			fiatuno.Accendi();
			fiatuno.Accendi();
			
			fiatuno.Spegni();
			fiatuno.Spegni();
			
		}
	}
}

