
SortedDictionary<char, int> charsCounts = new SortedDictionary<char, int>();
//Ще се пазят по абучен ред

string input = Console.ReadLine();

foreach (var ch in input)
{
	if (!charsCounts.ContainsKey(ch))
	{
		charsCounts.Add(ch, 0);
	}

	charsCounts[ch]++;
}

foreach (var charCounts in charsCounts)
{
	Console.WriteLine($"{charCounts.Key}: {charCounts.Value} time/s");
}
