using System;

class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    
    public Person(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine("Name:" + Name);
        Console.WriteLine("Surname:" + Surname);
        Console.WriteLine("Age:" + Age);
    }
}
