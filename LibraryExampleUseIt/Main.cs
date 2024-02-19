using System;
using LibraryExampleShared;

namespace LibraryExampleUseIt
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			TestLibraryShared test = new TestLibraryShared();
			test.DoIt();
			
			//NOT ACCESSIBLE
			//TestLibraryInternal ti = new TestLibraryInternal();
			//ti.DoIt();
		}
	}
}

