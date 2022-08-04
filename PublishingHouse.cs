namespace Library;

public class PublishingHouse
{
    public string Name { get; private set; }
    public string City { get; private set; }
    public string Country { get; private set; }
    public HashSet<string> books { get; private set; } // i think its better to link by title than the whole object

    public PublishingHouse(string name, string city, string country, List<Book> books)
    {
        Name = name;
        City = city;
        Country = country;
        this.books = new HashSet<string>();
    }

    public PublishingHouse()
    {
    }
}