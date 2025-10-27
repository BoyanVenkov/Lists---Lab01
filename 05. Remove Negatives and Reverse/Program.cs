List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> output = new List<int>();
int negativeCount = 0;

for (int i = 0; i < input.Count; i++)
{
    if (input[i] >= 0)
    {
        output.Add(input[i]);
        negativeCount++;
    }
}
if (negativeCount == 0)
{
    Console.WriteLine("empty");
    return;
}
output.Reverse();
Console.WriteLine(string.Join(" ", output));
