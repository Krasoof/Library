namespace Library.Console;

public class PublishingHouse
{
    public string Name { get; private set; }

    public string City { get; private set; }

    public string Country { get; private set; }

    public List<Book> Books { get; private set; } = new();

    public PublishingHouse(string name, string city, string country)
    {
        Name = name;
        City = city;
        Country = country;
    }
}