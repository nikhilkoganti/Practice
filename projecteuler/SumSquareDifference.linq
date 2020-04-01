<Query Kind="Program" />

void Main()
{
	long sumOfTheSquares = SumeOfTheSquares(100);
	
	long squareOfTheSum = SquareOfTheSum(100);
	
	Console.WriteLine("Result: " + (squareOfTheSum - sumOfTheSquares));
}

// Define other methods and classes here
public long SumeOfTheSquares(int num)
{
	long retNum = 0;
	for(int i = 1; i <= 100; i++)
	{
		retNum+= i * i;
	}
	
	return retNum;
}
public long SquareOfTheSum(int num)
{
	long retNum = num * (num + 1) / 2;
	
	return retNum * retNum;
}