using System.Runtime.CompilerServices;

internal class Program
{
	private static void Main(string[] args)
	{
		//ALL ARITHMETIC OPERATORS
		int x, y;
		x = 5;
		y = 10;

		//Console.WriteLine(x + y);
		//Console.WriteLine(x - y);
		//Console.WriteLine(x * y);
		//Console.WriteLine(y % x);

		//Console.WriteLine(x++);
		//Console.WriteLine(y--);

		//double a = 5.00D;
		//double b = 10.00D;

		//Console.WriteLine(a / b);

		//ALL ASSIGNMENT OPERATORS
		//int myNum = 5;
		//myNum += 3;
		//Console.WriteLine(myNum);

		//myNum -= 5;
		//Console.WriteLine(myNum);

		//myNum *= 10;
		//Console.WriteLine(myNum);

		//myNum %= 7;
		//Console.WriteLine(myNum);

		//double myDouble = myNum;
		//myDouble /= 8;
		//Console.WriteLine(myDouble);

		//myNum &= 9;
		//Console.WriteLine(myNum);

		//myNum |= 2;
		//Console.WriteLine(myNum);

		//myNum ^= 1;
		//Console.WriteLine(myNum);

		//myNum = 1100;
		//myNum >>= 1;
		//Console.WriteLine(myNum);

		//myNum <<= 2;
		//Console.WriteLine(myDouble);

		//COMPARISON OPERATORS
		//bool isTrueFalse = x == y;
		//Console.WriteLine(isTrueFalse);

		//isTrueFalse = x != y;
		//Console.WriteLine(isTrueFalse);

		//isTrueFalse = x > y;
		//Console.WriteLine(isTrueFalse);

		//isTrueFalse = x < y;
		//Console.WriteLine(isTrueFalse);

		//isTrueFalse = x >= y;
		//Console.WriteLine(isTrueFalse);

		//isTrueFalse = x <= y;
		//Console.WriteLine(isTrueFalse);

		//LOGICAL OPERATORS

		//Returns True if both statements are true
		bool isTrueFalse = x < 5 && x < 10;
		Console.WriteLine(isTrueFalse);

	   //Returns True if one of the statements is true
		isTrueFalse = x < 5 || x < 4;
		Console.WriteLine(isTrueFalse);

		//Returns False if the result is true
		isTrueFalse = !(x < 5 && x < 10);
		Console.WriteLine(isTrueFalse);

		//MATH

		int maxNum = Math.Max(x, y);
		Console.WriteLine(maxNum);

		int minNum = Math.Min(x, y);
		Console.WriteLine(minNum);

		double roundNum = Math.Round(9.4989);
		Console.WriteLine(roundNum);

		double sqrtNum = Math.Sqrt(169);
		Console.WriteLine(sqrtNum);

		double absNum = Math.Abs(-roundNum);
		Console.WriteLine(absNum);

	}
}