<Query Kind="Program" />

void Main()
{

	string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
	digits.Dump();
	
	var shortDigits = digits.Where((digit, index)=>digit.Length<index);
	//var shortDigits = digits.Where((x, y)=>x.Length<y);
	shortDigits.Dump();
	
	Console.WriteLine("Short digits:");
	foreach(var d in shortDigits)
	{
		Console.WriteLine("The word {0} is shorter than its value.", d);
	}
}


