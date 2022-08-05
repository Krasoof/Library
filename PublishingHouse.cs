namespace Library;

public class PublishingHouse
{
    public string Name { get; private set; }
    public string City { get; private set; }
    public string Country { get; private set; }

    public PublishingHouse(string name, string city, string country, List<Book> books)
    {
        Name = name;
        City = city;
        Country = country;
        
    }

    public PublishingHouse()
    {
    }
}