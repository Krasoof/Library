// See https://aka.ms/new-console-template for more information

using Library.Console;


var publishingHouses = new List<PublishingHouse>
{
    new PublishingHouse("Publishing1", "Lublin", "Ponikwoda"),
    new PublishingHouse("Publishing2", "Warszawa", "Diamentowa")
};

var authors = new List<Author>
{
    new Author("George", "Marting", 60),
    new Author("Dupa", "Wolowa", 25)
};

var book = new Book("Gra o tron", new DateTime(2022, 10, 10),  Genre.Fantasy, "1234", authors.First(), publishingHouses.First());

var libraryFacility = new LibraryFacility(16, "Kasztanowa", 20);
libraryFacility.AddLibrarian(new Librarian("Karol", "Niedziela", 24, 1700m, 10));

var reader = new Reader("Test", "Reader");

var firstBookBorrow = new BookBorrow(DateTime.Now, book, libraryFacility);
reader.BorrowBook(firstBookBorrow);

libraryFacility.BorrowedBooks.Add(firstBookBorrow);

Console.WriteLine("Hello, World!");