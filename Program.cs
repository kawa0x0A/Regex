using System.Text.RegularExpressions;

string input = Console.ReadLine()!;

Console.WriteLine(Regex.IsMatch(input, "一十百千(万丈目サンダー|満点サロメ)!"));

Console.ReadKey();