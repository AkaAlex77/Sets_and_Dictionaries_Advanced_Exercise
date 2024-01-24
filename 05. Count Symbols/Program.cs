SortedDictionary<char, int> charsCounter = new();

string input = Console.ReadLine();

foreach (var ch in input)
{
    if (!charsCounter.ContainsKey(ch))
    {
        charsCounter.Add(ch, 0);
    }
    charsCounter[ch]++;
}

foreach (var item in charsCounter)
{
    Console.WriteLine($"{item.Key}: {item.Value} time/s");
}



