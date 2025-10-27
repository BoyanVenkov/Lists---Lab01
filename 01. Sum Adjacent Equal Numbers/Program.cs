List<double> input = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

for (int i = 0; i < input.Count - 1; i++)
{
    double sum = 0;
    if (input[i] == input[i + 1])
    {
        sum = input[i] + input[i + 1];
        input.RemoveAt(i + 1);
        input.RemoveAt(i);
        input.Insert(i, sum);

        i = -1;
        sum = 0;
    }
}
Console.WriteLine(String.Join(" ", input));