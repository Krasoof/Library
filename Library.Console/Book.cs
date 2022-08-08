using System.Text;

namespace Library.Console;
public class Book
{
    public string Title { get; private set; }
   
    public DateTime ReleaseDate { get; private set; }

    public int? NumberOfPages{ get; private set; }

    public Genre Genre { get; private set; }
    
    public BookState BookState { get;  set; } 

    public string ISBN { get; set; }

    public Author Author { get; private set; }

    public PublishingHouse PublishingHouse { get; private set; }

    //public LibraryFacility LibraryFacility { get; private set; }    

    public Book(string title,
                DateTime releaseDate,
                Genre genre,
                string isbn,
                Author author,
                PublishingHouse publishingHouse,
                BookState bookState = BookState.Good,
                int? numberOfPages = null)
    {
        Title = title;
        ReleaseDate = releaseDate;
        NumberOfPages = numberOfPages;
        if (numberOfPages < 0) throw new ArgumentException();
        ISBN = isbn;
        BookState = bookState;
        Genre = genre;
        BookState = bookState;
        PublishingHouse = publishingHouse;
        Author = author;
    }

    private sealed class IsbnEqualityComparer : IEqualityComparer<Book>
    {
        public bool Equals(Book x, Book y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.ISBN == y.ISBN;
        }

        public int GetHashCode(Book obj)
        {
            return obj.ISBN.GetHashCode();
        }
    }

    public static IEqualityComparer<Book> IsbnComparer { get; } = new IsbnEqualityComparer();
}