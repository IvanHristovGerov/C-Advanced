
SortedDictionary<string, SortedSet<string>> sideUsers =
    new SortedDictionary<string, SortedSet<string>>();

string command = string.Empty;

while ((command = Console.ReadLine()) != "Lumpawaroo")
{


    if (command.Contains("|"))
    {
        string[] tokens = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
        string side = tokens[0];
        string user = tokens[1];

        if (!sideUsers.Values.Any(u => u.Contains(user)))
        {
            if (!sideUsers.ContainsKey(side))
            {
                sideUsers.Add(side, new SortedSet<string>());
            }

            sideUsers[side].Add(user);
        }

    }
    else
    {
        string[] tokens = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
        string user = tokens[0];
        string side = tokens[1];

        foreach (var currentUsers in sideUsers)
        {
            if (currentUsers.Value.Contains(user))
            {
                currentUsers.Value.Remove(user);
            }
        }

        if (!sideUsers.ContainsKey(side))
        {
            sideUsers.Add(side, new SortedSet<string>());
        }

        sideUsers[side].Add(user);

        Console.WriteLine($"{user} joins the {side} side!");
    }
}

var orderedSidesUsers = sideUsers
    .OrderByDescending(s => s.Value.Count)
    .ToDictionary(s => s.Key, s => s.Value);

foreach (var sideusers in orderedSidesUsers)
{
    if (sideusers.Value.Count > 0)
    {
        Console.WriteLine($"Side: {sideusers.Key}, Members: {sideusers.Value.Count}");

        foreach (var user in sideusers.Value)
        {
            Console.WriteLine($"! {user}");
        }
    }
}


