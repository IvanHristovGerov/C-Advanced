
int n = int.Parse(Console.ReadLine());

Dictionary<int, int> numbers = new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

	if (!numbers.ContainsKey(number))
	{
		numbers.Add(number, 0);
	}

	numbers[number]++;
}

Console.WriteLine(numbers.Single(n => n.Value % 2 == 0).Key);
//This gives the only one numbers from the dictionary that is Add-ed twice and it is % 2==0