<Query Kind="Program" />

void Main()
{
	long bigNum = 600851475143;
	
	Stack<long> returnStack = new Stack<long>();
	
	for(long i=2; i <= bigNum / 2; i++)
	{
		if (bigNum % i == 0)
		{
			if (IsPrime(bigNum / i))
			{
				Console.WriteLine(bigNum / i);
				return;
			}
			else if(IsPrime(i))
			{
				returnStack.Push(i);
			}
		}
	}
	
	Console.WriteLine(returnStack.Pop());
}

// Define other methods and classes here
public static bool IsPrime(long n)
{
	for(int i = 2; i < n / 2; i++)
	{
		if (n % i == 0)
			return false;
	}
	
	return true;
}