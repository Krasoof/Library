namespace Library;

public class Author
{
    

    public string Name { get; private set; }
    public  string Surrname { get; private set; }
    public int Age { get; private set; }

    public HashSet<PublishingHouse> AuthorHouses;



    public Author(string name, string surrname, int age)
    {
        Name = name;
        Surrname = surrname;
        Age = age;
        this.AuthorHouses = new HashSet<PublishingHouse>();
    }

    public Author()
    {
    }
}