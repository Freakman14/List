List<int> it = new() { 1, 23, 4, 312, 43, 90 };
int add = 12;
it.Add(add);
foreach (var item in it)
{
    System.Console.WriteLine(item);
}