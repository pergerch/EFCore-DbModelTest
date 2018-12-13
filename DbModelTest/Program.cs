namespace DbModelTest
{
	using System;
	using System.Linq;

	public class Program
	{
		static void Main(string[] args)
		{
			using (CorrectContext correctContext = new CorrectContext())
			{
				int i = correctContext.Measurements.Count();
				Console.WriteLine(i);
			}

			using (IncorrectContext incorrectContext = new IncorrectContext())
			{
				int i = incorrectContext.Measurements.Count();
				Console.WriteLine(i);
			}

			Console.WriteLine("Hello World!");
		}
	}
}