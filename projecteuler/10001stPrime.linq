<Query Kind="Program" />

void Main()
{
	int index = 0;
	int num = 2;
	
	int whichIndexPrime = 10001;
	
	while (index < whichIndexPrime)
	{
		if (IsPrime(num))
		{
			index++;
		}
		
		if (index != whichIndexPrime)
			num++;
	}
	
	Console.WriteLine("Result: "+ num);
}

// Define other methods and classes here
public static bool IsPrime(int num)
{
	for (int i = 2; i*i <= num; i++)
	{
		if (num % i == 0)
		{
			return false;
		}
	}
	
	return true;
}
	