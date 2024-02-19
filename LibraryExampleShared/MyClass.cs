using System;
namespace LibraryExampleShared
{
	public class TestLibraryShared
	{
		public void DoIt()
		{
			Console.WriteLine("TestLibraryShared call");
			TestLibrarySharedInternal ti = new TestLibrarySharedInternal();
			ti.DoIt();
		}
	}
	
	class TestLibrarySharedInternal
	{
		public void DoIt()
		{
			Console.WriteLine("TestLibrarySharedInternal");
		}
	}
}

