<Query Kind="Program" />

void Main()
{
	int retSum = 0;
	for(int i = 3; i < 1000; i+=3)
	{
		retSum+=i;
	}
	
	for(int i = 5; i < 1000; i+=5)
	{
		if(i % 3 != 0)
			retSum+=i;
	}
	
	Console.WriteLine(retSum);
}

// Define other methods and classes here
