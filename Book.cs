namespace Library;
public class Book
{
    public string title { get;  private  set; }

    public Author _author { get; private set; }
    
    public DateTime date { get; private set; }
    public int isbn{ get; private  set; }
    public int countPage{ get; set; }

    public  bool isBorrowed { get; private set; }

    public Genere genere { get; private set; }
    
    public BookState _bookState { get; private set; }

    public Book(string title, DateTime date, int isbn, int countPage, Genere genere, BookState bookState, Author author)
    {
        this.title = title;
        this.date = date;
        this.isbn = isbn;
        this.countPage = countPage;
        this.genere = genere;
        this._bookState = bookState;
        this._author = author;
        this.isBorrowed = false;

    }

    public Book()
    {
    }
}