using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        List<int> originalNumbers = new List<int>(numbers);
        bool isChanged = false;

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] parts = command.Split();
            string action = parts[0];

            switch (action)
            {
                case "Add":
                    int numberToAdd = int.Parse(parts[1]);
                    numbers.Add(numberToAdd);
                    isChanged = true;
                    break;
                case "Remove":
                    int numberToRemove = int.Parse(parts[1]);
                    numbers.Remove(numberToRemove);
                    isChanged = true;
                    break;
                case "RemoveAt":
                    int indexToRemove = int.Parse(parts[1]);
                    numbers.RemoveAt(indexToRemove);
                    isChanged = true;
                    break;
                case "Insert":
                    int numberToInsert = int.Parse(parts[1]);
                    int indexToInsert = int.Parse(parts[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                    isChanged = true;
                    break;
                case "Contains":
                    int numberToFind = int.Parse(parts[1]);
                    if (numbers.Contains(numberToFind))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;
                case "PrintEven":
                    List<int> evens = numbers.Where(n => n % 2 == 0).ToList();
                    Console.WriteLine(string.Join(" ", evens));
                    break;
                case "PrintOdd":
                    List<int> odds = numbers.Where(n => n % 2 != 0).ToList();
                    Console.WriteLine(string.Join(" ", odds));
                    break;
                case "GetSum":
                    long sum = 0;
                    foreach (int num in numbers)
                    {
                        sum += num;
                    }
                    Console.WriteLine(sum);
                    break;
                case "Filter":
                    string condition = parts[1];
                    int filterNumber = int.Parse(parts[2]);

                    List<int> filtered = FilterNumbers(numbers, condition, filterNumber);
                    Console.WriteLine(string.Join(" ", filtered));
                    break;
            }
        }

        if (isChanged)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
    private static List<int> FilterNumbers(List<int> list, string condition, int number)
    {
        return condition switch
        {
            "<" => list.Where(n => n < number).ToList(),
            ">" => list.Where(n => n > number).ToList(),
            "<=" => list.Where(n => n <= number).ToList(),
            ">=" => list.Where(n => n >= number).ToList(),
            _ => new List<int>()
        };
    }
}