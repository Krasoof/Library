namespace Library.Domain.Entities;

public class Author
{
    public int Id { get; private set; }

    public string Name { get; private set; }

    public string Surrname { get; private set; }

    public int Age { get; private set; }

    public HashSet<Book> Books { get; private set; } = new();

    public Author(string name, string surrname, int age)
    {
        Name = name;
        Surrname = surrname;
        if (age < 12) throw new Exception();
        Age = age;
    }
}