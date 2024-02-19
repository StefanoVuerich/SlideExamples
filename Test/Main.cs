using System;
using System.Collections.Generic;

namespace Test
{
	sealed class Wonderful
	{
		public void FaiQuesto()
		{
			//
		}
		
		public int FaiQuello()
		{
			//
			return 10;
		}
	}
	
	class MoreWonderful
	{
		private Wonderful wonderful = new Wonderful();
		
		public void FaiQuesto()
		{
			wonderful.FaiQuesto();
		}
		
		public int FaiQuello()
		{
			return wonderful.FaiQuello();
		}
		
		public void FaiQuestaltro()
		{
			//
		}
	}
	
	class MainClass
	{

		public static void Main (string[] args)
		{
			Wonderful w = new Wonderful();
			w.FaiQuesto();
			w.FaiQuello();
			//w.FaiQuestaltro();
			
			MoreWonderful ww = new MoreWonderful();
			ww.FaiQuesto();
			ww.FaiQuello();
			ww.FaiQuestaltro();
			
		}
	}
}


