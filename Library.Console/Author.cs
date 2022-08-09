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
        if (book.Author.Equals(this)) //we cannot add Book other author to our list
        {
            Books.Add(book);
        }
        else
        {
            throw new InvalidOperationException("");
        }
    }

    public void AddBooksToAuthor(HashSet<Book> books)
    {
        var NonExistingBooks = books.Where(e => e.Author.Equals(this)).ToHashSet();
        //we collect books with same author 

        Books.Union(books);

    }
    public Author(string name, string surrname, int age)
    {
        Name = name;
        Surrname = surrname;
        if (age < 12) throw new Exception();
        Age = age;
    }

    protected bool Equals(Author other)
    {
        return Surrname == other.Surrname;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Author)obj);
    }

    public override int GetHashCode()
    {
        return Surrname.GetHashCode();
    }
}