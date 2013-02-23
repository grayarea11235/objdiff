using System;

namespace objdiff
{
	class Test1 
	{
		public int a { get; set; }
		public bool b { get; set; }
		public string c { get; set; }
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			var left = new Test1()
			{
				a = 1,
				b = true,
				c = "First string"
			};
			
			var right = new Test1()
			{
				a = 2,
				b = false,
				c = "Second string"
			};
			
			var comp = new ObjectDifference();
			comp.ComparePorperties(left, right);

			Console.WriteLine ("Hello World!");
		}
	}
}
