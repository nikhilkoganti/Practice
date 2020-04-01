<Query Kind="Program" />

void Main()
{
	int prevNumber = 1;
	int currentNumber = 2;
	int tempNumber;
	int retSum = 0;
	
	while (currentNumber <= 4000000)
	{
		if (currentNumber % 2 == 0)
		{
			retSum+=currentNumber;
		}
		
		tempNumber = currentNumber;
		currentNumber+=prevNumber;
		prevNumber = tempNumber;
	}
	
	Console.WriteLine(retSum);
}

// Define other methods and classes here
