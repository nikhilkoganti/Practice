<Query Kind="Program" />

void Main()
{
	bool debug = false;
	Dictionary<int, int> overallFactors = new Dictionary<int, int>();
	
	if (debug)
		Console.WriteLine("num: 2520");
	Dictionary<int, int> factors = Factorize(2520, debug);
	Merge(overallFactors, factors, debug);
	
	for(int i=11; i<=20; i++)
	{	
		if (debug)
			Console.WriteLine("num: " + i);
		factors = Factorize(i, debug);
		Merge(overallFactors, factors, debug);
	}
	
	Console.WriteLine("Final result:" + CombineFactors(overallFactors, debug));
}

// Define other methods and classes here
public static Dictionary<int, int> Factorize(int num, bool debug)
{

	int i = 2;
	int newNum = num;
	Dictionary<int, int> factors = new Dictionary<int, int>();
	
	while (i*i <= newNum)
	{
		if (newNum % i == 0)
		{
			if (factors.ContainsKey(i))
				factors[i]++;
			else
				factors[i] = 1;
			newNum = newNum / i;
		}
		else
		{
			i++;
		}
	}
	
	if (factors.ContainsKey(newNum))
		factors[newNum]++;
	else
		factors[newNum] = 1;
		
	return factors;
}

public static void Merge(Dictionary<int, int> overallFactors, Dictionary<int, int> factors, bool debug)
{
	if (debug)
		Console.WriteLine("merge begin");
		
	foreach(KeyValuePair<int, int> entry in factors)
	{		
		if (debug)
			Console.WriteLine("		factor:" + entry.Key + ", count:" + entry.Value);
	    if (!overallFactors.ContainsKey(entry.Key) || factors[entry.Key] > overallFactors[entry.Key])
			overallFactors[entry.Key] = entry.Value;
	}
	
	if (debug)
		Console.WriteLine("merge end");
}

public static double CombineFactors(Dictionary<int, int> overallFactors, bool debug)
{
	double multiple = 1;
	
	foreach(KeyValuePair<int, int> entry in overallFactors)
	{
		multiple = multiple * Math.Pow(entry.Key, entry.Value);
	}
	
	return multiple;
}