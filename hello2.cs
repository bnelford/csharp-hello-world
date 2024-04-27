using System;
using MyNameSpace;

class Program
{
	static void Main()
	{
		Console.WriteLine("Hello world!");
		
		Calculator calc = new Calculator();
		double a = 4.5;
		double b = 5.0;
		double c = calc.Add(a,b);
		Console.WriteLine("{0} + {1} = {2}", a, b, c);
	}
}