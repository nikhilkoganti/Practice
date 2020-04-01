<Query Kind="Program" />

void Main()
{
	var largestPalindrome = 0;
	for(int i = 999; i > 0; i--)	
	{
		for(int j = 999; j > 0; j--)	
		{
			int ij = i * j;
			if(IsPalindrome(ij))
			{
				if(ij > largestPalindrome)
					largestPalindrome = ij;
					
				break;
			}
		}
	}
	
	Console.WriteLine(largestPalindrome);
}

// Define other methods and classes here
public static bool IsPalindrome(int num)
{
	string numString = num.ToString();
	
	int numLength = numString.Length;
	
	for(int i = 0; i <= numLength / 2; i++)
	{
		if(numString[i] != numString[numLength - i - 1])
			return false;
	}
	
	return true;
}