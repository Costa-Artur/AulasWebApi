using Microsoft.EntityFrameworkCore;
using UnivaliEF;
using UnivaliEF.Contexts;
using UnivaliEF.Entities;

using var _context = new PublisherContext();

_context.Database.EnsureDeleted();
_context.Database.Migrate();

void GetAllAuthorsWithTheirCourses ()
{
    var authrosWithCourses = _context.Authors
        .Include(a => a.Courses);
}

void ConnectExistingAuthorAndCourse()
{
    var authorA = _context.Authors.Find(1);
    var authorB = _context.Authors.Find(2);
    var courseA = _context.Courses.Find(1);

    courseA.Authors.Add(authorA);
    courseA.Authors.Add(authorB);

    var courseB = _context.Courses.Find(2);
}

//AddMultipleCourses();

void AddMultipleCourses ()
{
    var courses = new List<Course>
    {
        new Course (
            "Api",
            97.00m,
            "Api"
        ),
        new Course (
            "Entity Framework",
            197.00m,
            "Entity Framework"
        ),
        new Course (
            "Linux",
            47.00m,
            "Linux"
        ),
    };

    _context.AddRange(courses);
    _context.SaveChanges();
}

// AddMultipleAuthors();
// SortAuthors();

void SortAuthors()
{
    var authors = _context.Authors
        .OrderBy(a => a.FirstName)
        .ThenBy(a => a.LastName)
        .ToList();

    Util.PrintFullName(authors);
}

//UpdateMultipleAuthors();

void UpdateMultipleAuthors()
{
    var authors = _context.Authors
        .Where(a => a.LastName == "Torvalds")
        .ToList();

    foreach(var author in authors)
    {
        author.LastName = "Linux";
    }

    _context.SaveChanges();
    Util.Print(authors);
}

//GetMultipleAuthors();

void GetMultipleAuthors ()
{
    var authors = _context.Authors.ToList();
    Util.Print(authors);
}

//AddMultipleAuthors();

void AddMultipleAuthors ()
{
    var authors = new Author[]
    {
        new Author("Grace","Hopper"),
        new Author("John","Backus"),
        new Author("Jack","Torvalds"),
        new Author("Jack","Gates"),
        new Author("Bill","Gates"),
        new Author("Jim","Berners-Lee"),
        new Author("Linus","Torvalds"),
        new Author("Jack","Adams")
    };

    _context.AddRange(authors);
    _context.SaveChanges();
}

//RemoveAuthor();

void RemoveAuthor()
{
    var author = _context.Authors
        .FirstOrDefault(a => a.AuthorId == 10);

    _context.Authors.Remove(author);
    _context.SaveChanges();
}

void GetAuthor ()
{
    var author = _context.Authors
        .FirstOrDefault(a => a.FirstName == "James");

    Util.Print(author);
}

//GetAuthor();

void AddAuthor()
{
    var author = new Author("James", "Gosling");
    _context.Authors.Add(author);
    _context.SaveChanges();
}

//AddAuthor();

void UpdateAuthor ()
{
    var author = _context.Authors
        .FirstOrDefault(a => a.FirstName == "James");

    author.FirstName = "Jack";
    _context.SaveChanges();
    Util.Print(author);
}

//UpdateAuthor();