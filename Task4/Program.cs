List<double> num = new List<double>() { 3.5, 2.7, 6.9, 1.2 };
double sum = 0;
double average = 0;
foreach (var item in num)
{
    sum += item;
}
average = sum / num.Count;

System.Console.WriteLine("Average: " + average);