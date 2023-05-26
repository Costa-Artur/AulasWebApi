string? name1 = null;
string? name2 = null;
string? name3 = "Richard Stallman";
string defaultName = "Mark Zuckerberg";

if(name1 == null) 
{
    name1 = defaultName;
}

Console.WriteLine($"name1: {name1}");

name2 ??= defaultName;

Console.WriteLine($"name2: {name2}");

name3 ??= defaultName;

Console.WriteLine($"name3: {name3}");