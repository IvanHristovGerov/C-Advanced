HashSet<int> firstSet = new();
HashSet<int> secondSet = new HashSet<int>();

int[] counts = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < counts[0]; i++)
{
    firstSet.Add(int.Parse(Console.ReadLine()));
}
for (int i = 0; i < counts[1]; i++)
{
    secondSet.Add(int.Parse(Console.ReadLine()));
}

firstSet.IntersectWith(secondSet);

Console.WriteLine(String.Join(" ", firstSet));