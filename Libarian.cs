namespace Library;

public class Libarian
{
    public string Name { get; private set; }
    public string Surrname { get; private set; }
    public Library _Library { get; private set; }
    public int Age { get; private set; }
    public float Salary { get; private set; }
    public int Expo { get; set; }

    public Libarian(string name, string surrname, Library library, int age, float salary, int expo)
    {
        Name = name;
        Surrname = surrname;
        _Library = library;
        Age = age;
        Salary = salary;
        Expo = expo;
    }


    public Libarian()
    {
    }
}