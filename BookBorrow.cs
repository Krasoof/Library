namespace Library;

public class BookBorrow
{
    public DateTime  DateOfBorrow { get; private set; }
    public DateTime   DateOfReturn { get; private set; }
    public Book _Book { get; private set; }  // decide that we are supose to borrow one book on one BookBorrow

    public BookBorrow(DateTime dateOfBorrow, DateTime dateOfReturn, Book book)
    {
        DateOfBorrow = dateOfBorrow;
        DateOfReturn = dateOfReturn;
        _Book = book;
    }


    public BookBorrow()
    {
    }
}