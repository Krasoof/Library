namespace Library.Domain.Entities;

public class Librarian
{
    public string Name { get; private set; }

    public string Surname { get; private set; }

    public int Age { get; private set; }

    public decimal Salary { get; private set; }

    public int? Expo { get; private set; }

    public LibraryFacility Library { get; private set; } = default!;

    public Librarian(string name, string surname, int age, decimal salary, int? expo = null)
    {
        Name = name;
        Surname = surname;
        Age = age;
        if (age > 70) throw new InvalidOperationException();
        Salary = salary;
        if (salary < 0) throw new InvalidOperationException();
        Expo = expo;
        if (expo < 0) throw new InvalidOperationException();
    } 
}