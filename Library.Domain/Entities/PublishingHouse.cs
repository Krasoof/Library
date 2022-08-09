namespace Library.Domain.Entities;

public class PublishingHouse
{
    public int Id { get; private set; }

    public string Name { get; private set; }

    public string City { get; private set; }

    public string Country { get; private set; }

    public PublishingHouse(string name, string city, string country)
    {
        Name = name;
        City = city;
        Country = country;
    }
}