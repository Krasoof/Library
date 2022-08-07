namespace Library.Console;

public class LibraryFacility
{
    private const string DefaultCity = "Lublin";

    public int FacilityNumber { get; private set; }

    public string City { get; private set; } = "Lublin";

    public string Street { get; private set; } = default!;

    public int HouseNumber { get; private set; } = default!;

    public List<Librarian> Librarians { get; private set; } = new();

    public List<BookBorrow> BorrowedBooks { get; set; } = new();

    public HashSet<Book> Books { get; private set; } = new();

    public LibraryFacility(int facilityNumber, string street, int houseNumber, string city = DefaultCity)
    {
        FacilityNumber = facilityNumber;
        Street = street;
        HouseNumber = houseNumber;
        City = city;
    }

    public void AddLibrarian(Librarian librarian)
    {
        Librarians.Add(librarian);
    }

    public void AddBooks(HashSet<Book> books) 
    {
        Books.Union(books);
    } 
}