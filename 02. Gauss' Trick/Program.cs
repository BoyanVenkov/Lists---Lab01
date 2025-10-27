List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> output = new List<int>();
int sum = 0;

for (int i = 0; i <= input.Count - 1; i++)
{
    for (int j = input.Count - 1; j >= i; j--)
    {
        if (i == j)
        {
            output.Insert(i, input[i]);
            break;
        }
        sum = input[i] + input[j];
        output.Insert(i, sum);
        input.RemoveAt(j);
        sum = 0;
        break;
    }
}
Console.WriteLine(String.Join(" ", output));

