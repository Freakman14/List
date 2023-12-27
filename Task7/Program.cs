List<int> rem = new() { 1, 23, 34, 2, 4 };
rem.RemoveAt(3);
foreach (var item in rem)
{
    System.Console.WriteLine(item);
}