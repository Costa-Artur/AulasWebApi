namespace UnivaliEF.Entities;

public class Course
{
    public int CourseId {get;set;}
    public string Title {get;set;} = string.Empty;
    public string Description {get;set;} = string.Empty;
    public decimal Price {get;set;}
    public ICollection<Author> Authors {get;set;} = new List<Author>();

    public Course (string title, decimal price, string description)
    {
        Title = title;
        Price = price;
        Description = description;
    }
}