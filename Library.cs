namespace Library;

public class Library
{
    public int ID { get; private set; }
    public string City { get; private set; } = "Lublin";
    public string Street { get; private set; }
    public string Code { get; private set; }

    public Library(int id, string city, string street, string code)
    {
        ID = id;
        City = city;
        Street = street;
        Code = code;
    }

    public Library()
    {
    }
}