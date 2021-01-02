using System;
using System.Collections.Generic;

namespace _3PR_Lab_10_CSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Демонстрация работы исключений. */
			Console.WriteLine("Демонстрация работы исключений:");
			Building building = new Building();

			building.inputBuilding();
			building.getBuilding();
		}
	}
}