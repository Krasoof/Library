using System.ComponentModel.Design;

namespace Library.Console;

public class PublishingHouse
{
    public string Name { get; private set; }

    public string City { get; private set; }

    public string Country { get; private set; }

    public HashSet<Book> Books { get; private set; } = new(); // fkc list, we dont wanna duplicates


    public bool CheckBook(Book book) => Books.Where(e => e.ISBN == book.ISBN).Any();
    public void AddBook(Book book)
    {
        if (book.PublishingHouse.Equals(this))
        {
            Books.Add(book);
        }
        else
        {
            throw new InvalidOperationException("We didnt publish this book");
        }
    }
    

    public void StopSupportBook(Book book)
    {
        if (book.PublishingHouse.Equals(this))
        {
            Books.Remove(book);
        }
        else
        {
            throw new InvalidOperationException("We already dont supp this book");
        }
    }
    public PublishingHouse(string name, string city, string country)
    {
        Name = name;
        City = city;
        Country = country;
    }
}