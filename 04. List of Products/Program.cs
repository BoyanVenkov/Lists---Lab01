int input = int.Parse(Console.ReadLine());
string product = string.Empty;
int count = 1;
List<string> shoppingList = new List<string>();

for (int i = 1; i <= input; i++)
{ 
    product = Console.ReadLine();
    shoppingList.Add(product);

}
shoppingList.Sort();
foreach (string products in shoppingList)
{
    Console.WriteLine($"{count}.{products}");
    count++;
}