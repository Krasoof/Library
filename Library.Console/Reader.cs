namespace Library.Console
{
    public class Reader
    {
        private const int MaxNumberOfBorrowedBooks = 3;

        public string FirstName { get; private set; } = default!;

        public string LastName { get; private set; } = default!;

        public List<BookBorrow> BorrowedBooks { get; private set; } = new();

        public Reader(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void BorrowBook(BookBorrow bookBorrow)
        {
            if (BorrowedBooks.Count >= MaxNumberOfBorrowedBooks)
            {
                throw new InvalidOperationException("Invalid");
            }

            BorrowedBooks.Add(bookBorrow);
        }

        public void ReturnBook(string isbn)
        {
            var bookBorrow = BorrowedBooks.Where(bb => bb.Book.ISBN == isbn).FirstOrDefault();
            if (bookBorrow is null)
            {
                throw new ArgumentNullException("Book borrow not found");
            }

            if (bookBorrow.DateOfReturn < DateTime.Now)
            {
                throw new InvalidOperationException("Date of return exceeded.");
            }

            BorrowedBooks.Remove(bookBorrow);
        }
    }
}
