using System;
using System.Text;

namespace Lamp
{	
	
	public class KoLampException : Exception
	{
		public KoLampException ()
		{
		}
		
		public KoLampException (string message) : base (message)
		{
		}
		
		public KoLampException (string message, Exception inner) : base (message, inner)
		{
		}
		
		public int Hits { get; set; }
	}
	
	class Lamp
	{
		int _limit;
		int _onHits = 0;
		
		bool on = false;
		
		public Lamp(int limit)
		{
			_limit = limit;
		}
		
		public void On()
		{
			if (on)
				return;
			
			_onHits++;
			on = true;
			Console.WriteLine("Lamp on");
			
			if (_onHits > _limit)
			{
				KoLampException ko = new KoLampException();
				ko.Hits = _onHits;
				throw ko;
			}
		}
		
		public void Off()
		{
			if (!on)
				return;
			
			on = false;
			Console.WriteLine("Lamp off");
		}
		
	}
	
	class Circuit
	{
		private Lamp _lamp;
		
		public Circuit(Lamp lamp)
		{
			_lamp = lamp;
		}
		
		public void SwitchOn()
		{
			_lamp.On();
		}
		
		public void SwitchOff()
		{
			_lamp.Off();
		}
	}
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			Lamp lamp = new Lamp(5);
			
			Circuit circuit = new Circuit(lamp);
			
			try
			{
				int max = 10;
				do
				{
					circuit.SwitchOn();
					circuit.SwitchOff();
					max--;
				}
				while(max > 0);
			}
			catch(KoLampException ko)
			{
				Console.WriteLine("Lamp Ko after {0} ons", ko.Hits);
			}
			finally
			{
				circuit.SwitchOff();
			}
			
		}
	}
}

