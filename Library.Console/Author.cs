namespace Library.Console;

public class Author
{
    public string Name { get; private set; }

    public string Surrname { get; private set; }

    public int Age { get; private set; }

    public HashSet<Book> Books { get; private set; } = new();
    // fkc list, we dont wanna duplicates
    // Decide that we cant remove book from author

    public bool CheckBook(Book book) => Books.Where(e => e.ISBN == book.ISBN).Any();

    public void AddBookToAuthor(Book book)
    {
        if (book.Author.Equals(this))
        {
            Books.Add(book);
        }
    }

    public void AddBooksToAuthor(HashSet<Book> books)
    {
        foreach (var e in books)
        {

            if (e.Author.Equals(this))
            {
                Books.Add(e);
            }

            if (!e.Author.Equals(this))
            {
                throw new Exception("It not author");
            }
            
        }
       
    }
    public Author(string name, string surrname, int age)
    {
        Name = name;
        Surrname = surrname;
        if (age < 12) throw new Exception();
        Age = age;
    }
}