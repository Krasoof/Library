namespace Library.Console;

public class Librarian
{
    public string Name { get; private set; }

    public string Surname { get; private set; }

    //public LibraryFacility Library { get; private set; } = default!;

    public int Age { get; private set; }

    public decimal Salary { get; private set; }

    public int? Expo { get; private set; }


    public Librarian(string name, string surname, int age, decimal salary, int? expo = null)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Salary = salary;
        Expo = expo;
    }
}