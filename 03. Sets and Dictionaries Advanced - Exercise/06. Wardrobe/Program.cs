
Dictionary<string, Dictionary<string, int>> clothesByColor = 
    new Dictionary<string, Dictionary<string, int>>();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

    string color = tokens[0];

    if (!clothesByColor.ContainsKey(color))
    {
        clothesByColor.Add(color, new Dictionary<string, int>());
    }

    for (int j = 1; j < tokens.Length; j++)
    {
        string currentCloth = tokens[j];

        if (!clothesByColor[color].ContainsKey(currentCloth))
        {
            clothesByColor[color].Add(currentCloth, 0); //0 stands for how many times its encountered/срещано
        }

        clothesByColor[color][currentCloth]++;
    }
}

string[] findTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);



foreach (var clothColor in clothesByColor)
{
    Console.WriteLine($"{clothColor.Key} clothes:");

    foreach (var cloth in clothColor.Value)
    {
        string printItem = $"* {cloth.Key} - {cloth.Value}";

        if (clothColor.Key== findTokens[0] && cloth.Key == findTokens[1])
        {
            printItem += " (found!)";
        }

        Console.WriteLine(printItem);
    }
}