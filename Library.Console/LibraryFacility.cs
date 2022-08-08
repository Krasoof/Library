namespace Library.Console;

public class LibraryFacility
{
    private const string DefaultCity = "Lublin";

    public int FacilityNumber { get; private set; }

    public string City { get; private set; } = "Lublin";

    public string Street { get; private set; } = default!;

    public int HouseNumber { get; private set; } = default!;

    public HashSet<Librarian> Librarians { get; private set; } = new();

    public HashSet<BookBorrow> BorrowedBooks { get; set; } = new();

    public HashSet<Book> Books { get; private set; } = new();

    public LibraryFacility(int facilityNumber, string street, int houseNumber, string city = DefaultCity)
    {
        FacilityNumber = facilityNumber;
        Street = street;
        HouseNumber = houseNumber;
        City = city;
    }

    public bool CheckAvailability(Book book) => Books.Where(x => x.ISBN == book.ISBN).Any();
    
    public bool CheckThatBookBorrowedFromOurLib (Book book) => BorrowedBooks.Where(e =>e.Book.ISBN == book.ISBN).Any();
    
    
    
    public void AddLibrarian(Librarian librarian)
    {
        Librarians.Add(librarian);
    }

    public void AddBooks(HashSet<Book> books) 
    {
        Books.Union(books);
    }

    public void MoveFromBooksToBorrow(Book book, BookState state)
    {
        if (CheckAvailability(book))
        {
            var BookToBorrow = Books.Where(e => e.ISBN == book.ISBN).First();
            BorrowedBooks.Add(new BookBorrow(DateTime.Now, BookToBorrow, this));
            Books.Remove(BookToBorrow);
        }
    }

    public void MoveFromBorrowToBooks(Book book)
    {
        if (CheckThatBookBorrowedFromOurLib(book))
        {
            var BookToRecive = BorrowedBooks.Where(e => e.Book.ISBN == book.ISBN).First();
            BorrowedBooks.Remove(BookToRecive);
            Books.Add(BookToRecive.Book);
        }
            
    }
    

    public void AddBook(Book book)
    {
        if (book.BookState == BookState.Trash) throw new Exception("!!!");
        
        Books.Add(book);
    }

    
    
}