<Query Kind="Program" />

void Main()
{
	PrintPermutations("Nik");
}

public void PrintPermutations(string str, 0)
{
	PrintPermutations("Nik");
}

public void PrintPermutations(string str, int index)
{
	for(int i = 0; i < str.Length; i++)
	{
		Print(str[i] + "");
	}
}

public void Print(string str, bool newLine = true)
{
	Console.Write(str + "" + (newLine ? Environment.NewLine : ""));
}

public void Print(int str, bool newLine = true)
{
	Print(str + "", newLine);
}
