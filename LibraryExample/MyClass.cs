using System;
namespace LibraryExample
{
	public class TestLibrary
	{
		public void DoIt()
		{
			Console.WriteLine("TestLibrary call");
			TestLibraryInternal ti = new TestLibraryInternal();
			ti.DoIt();
		}
	}
	
	class TestLibraryInternal
	{
		public void DoIt()
		{
			Console.WriteLine("TestLibraryInternal");
		}
	}
}

