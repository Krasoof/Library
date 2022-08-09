using Library.Domain.Constants;

namespace Library.Domain.Entities;

public class BookBorrow
{
    private const int DefaultLengthOfBorrow = 1;

    public DateTime DateOfBorrow { get; private set; }

    public DateTime DateOfReturn { get; private set; }

    public Book Book { get; private set; }

    public BookState BookStateBeforeBorrow { get; private set; }

    public BookState? BookStateAfterReturn { get; private set; }

    public int ReaderId { get; private set; }

    public Reader Reader { get; private set; }

    public LibraryFacility LibraryFacility { get; private set; }

    public BookBorrow(DateTime dateOfBorrow, Book book, LibraryFacility libraryFacility, Reader reader)
    {
        DateOfBorrow = dateOfBorrow;
        DateOfReturn = dateOfBorrow.AddMonths(DefaultLengthOfBorrow);
        Book = book;
        BookStateBeforeBorrow = book.BookState;
        Reader = reader;
        LibraryFacility = libraryFacility;
    }
}