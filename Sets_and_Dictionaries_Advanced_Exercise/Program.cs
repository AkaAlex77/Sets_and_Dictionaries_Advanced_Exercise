int n = int.Parse(Console.ReadLine());

HashSet<string> userNames = new();

for (int i = 0; i < n; i++)
{
    userNames.Add(Console.ReadLine());
}

foreach (var item in userNames)
{
    Console.WriteLine(item);
}

