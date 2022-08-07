namespace Library;
public class Book
{
    public string Title { get;  private  set; }

    public Author _Author { get; private set; }
    
    public DateTime date { get; private set; }
    public int Isbn{ get; private  set; }
    public int ? CountPage{ get; set; }

    public  bool IsBorrowed { get; private set; }

    public Genere _Genere { get; private set; }
    
    public BookState _bookState { get; private set; }

    public Book(string title, DateTime date, int isbn, int countPage, Genere genere, BookState bookState, Author author)
    {
        this.Title = title;
        this.date = date;
        this.Isbn = isbn;
        this.CountPage = countPage;
        this._Genere = genere;
        this._bookState = bookState;
        this._Author = author;
        this.IsBorrowed = false;

    }

    public Book()
    {
    }
}