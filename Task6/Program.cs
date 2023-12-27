List<bool> cip = new() { true, true, true };
bool allTrue = cip.Exists(e => e == true);
System.Console.WriteLine("Are all the values in the list true? " + allTrue);