
// string[] firstNames = new string[5]
List<string> firstNames = new List<string>();

firstNames.Add("Tim");
firstNames.Add("Bob");
firstNames.Add("Sue");
firstNames.Add("Kane");
firstNames.Add("Barney");

//Console.WriteLine(firstNames[firstNames.Count - 1]);

// List<T> - generic

string data = "Corey,Smith,Jones";

List<string> lastNames = data.Split(',').ToList();
lastNames.Add("Franklin");

foreach (string name in lastNames)
{
    Console.WriteLine(name);
}
