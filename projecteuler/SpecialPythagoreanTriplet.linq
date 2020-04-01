<Query Kind="Program" />

void Main()
{
	var squares = GetSquaresLessThan(1000); 
	var debug = true;
	
	if (debug)
		foreach(var num in squares)
			Console.WriteLine(num);
		
}

// Define other methods and classes here
public static List<int> GetSquaresLessThan(int num)
{
	List<int> retList = new List<int>();
	
	for (int i = 1; i * i <= num; i++)
	{
		retList.Add(i * i);
	}
	
	return retList;
}