using System.ComponentModel;

List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> output = new List<int>();


if (list1.Count >= list2.Count)
{
    int indexCount = 0;
    int jCount = 0;
    for (int i = 0; i <= list1.Count - 1; i++)
    {
        output.Insert(indexCount, list1[i]);
        indexCount++;
        for (int j = jCount; jCount <= list2.Count - 1;)
        {
            output.Insert(indexCount, list2[j]);
            jCount++;
            indexCount++;
            break;
        }
    }
}
if (list2.Count > list1.Count)
{
    int indexCount = 0;
    int iCount = 0;
    for (int j = 0; j <= list2.Count - 1; j++)
    {
        output.Insert(indexCount, list2[j]);
        indexCount++;
        for (int i = iCount; i <= list1.Count - 1;)
        {
            output.Insert(indexCount - 1, list1[i]);
            indexCount++;
            iCount++;
            break;
        }
    }
}
Console.WriteLine(String.Join(" ", output));