using System;

namespace Vocali
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int consonanti = 0;
			int vocali = 0;
			string str = "ciao!";
			foreach(char c in str.ToLower().ToCharArray())
			{
				if (c < 'a' || c > 'z')
					continue;

				switch(c)
				{
					case 'a':
						vocali++;
						break;
					case 'i':
						vocali++;
						break;
					case 'u':
						vocali++;
						break;
					case 'o':
						vocali++;
						break;
					case 'e':
						vocali++;
						break;
					default:
						consonanti++;
						break;
				}
			}
			Console.WriteLine(str);
			Console.WriteLine("Vocali: " + vocali);
			Console.WriteLine("Consonanti: " + consonanti);
		}
	}
}

