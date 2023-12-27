List<int> number = new() { 1, 2, 3, 4, 5 };
System.Console.WriteLine("The filtered numbers are: ");
List<int> numbers = number.FindAll(e => e % 2 == 0);
foreach (var item in numbers)
{
    System.Console.WriteLine(item);
}