using UnivaliEF.Entities;
namespace UnivaliEF;

public static class Util
{
    public static void Print (Author author)
    {
        Console.WriteLine("\n================================================================================================");
        Console.WriteLine(author);
        Console.WriteLine("================================================================================================");
    }

    public static void Print (List<Author> authors)
    {
        Console.WriteLine("\n================================================================================================");
        foreach (var author in authors)
        {
            Console.WriteLine(author);
            Console.WriteLine("================================================================================================");
        }
    }

    public static void PrintFullName (List<Author> authors)
    {
        foreach (var author in authors)
        {
            Console.WriteLine(author.FirstName + " " + author.LastName);
        }
    }
}