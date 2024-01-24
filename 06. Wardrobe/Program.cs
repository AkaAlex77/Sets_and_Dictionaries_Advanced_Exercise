int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> wardrobe = new();

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split(new string[] {","," -> "}, StringSplitOptions.RemoveEmptyEntries);

    string color = tokens[0];

    if (!wardrobe.ContainsKey(color))
    {
        wardrobe.Add(color, new Dictionary<string, int>());

    }

    for (int j = 0; j < tokens.Length; j++)
    {
        string currentWear = tokens[j];

        if (!wardrobe[color].ContainsKey(currentWear))
        {
            wardrobe[color].Add(currentWear, 0);
        }

        wardrobe[color][currentWear]++;
    }
}

string[] findParams = Console.ReadLine().Split();

string findColer = findParams[0];

string findDrip = findParams[1];

foreach (var color in wardrobe)
{
    Console.WriteLine($"{color.Key} clothes:");

    foreach (var wearCount in color.Value)
    {
        string printItem = $"* {wearCount.Key} - {wearCount.Value}";

        if (color.Key == findColer && wearCount.Key == findDrip)
        {
            printItem += " (found!)";
        }

        Console.WriteLine(printItem);
    }
}

