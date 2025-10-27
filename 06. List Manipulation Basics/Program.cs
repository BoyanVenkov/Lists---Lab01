List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
string[] command = Console.ReadLine().Split().ToArray();

while (command[0] != "end")
{
    if (command[0] == "Add")
    {
        input.Add(int.Parse(command[1]));
    }
    if (command[0] == "Remove")
    {
        input.Remove(int.Parse(command[1]));
    }
    if (command[0] == "RemoveAt")
    {
        input.RemoveAt(int.Parse(command[1]));
    }
    if (command[0] == "Insert")
    {
        input.Insert(int.Parse(command[2]), int.Parse(command[1]));
    }
    command = Console.ReadLine().Split().ToArray();
}
Console.WriteLine(string.Join(" ", input));