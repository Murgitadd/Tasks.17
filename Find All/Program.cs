using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
    	
        List<Person> people = new List<Person>();


        people.Add(new Person("Kamil", "Nesirli", 30));
        people.Add(new Person("Murad", "Khasaddinov", 25));
        people.Add(new Person("Kamil", "Esedov", 40));
        people.Add(new Person("Shamama", "Mumova", 21));
        people.Add(new Person("Zulfiya", "Qedemli", 16 ));                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      

        Console.WriteLine("Kamil:");
        var sameName = people.FindAll(person => person.Name == "Kamil");
        foreach (var person in sameName)
        {
            person.DisplayInfo();
            Console.WriteLine();
        }

       Console.WriteLine("'ov' or 'ova':");
var surOva = people.FindAll(person => person.Surname.EndsWith("ov") || person.Surname.EndsWith("ova"));
foreach (var person in surOva)
{
    person.DisplayInfo();
    Console.WriteLine();
}


        Console.WriteLine("20+:");
        var over20 = people.FindAll(person => person.Age > 20);
        foreach (var person in over20)
        {
            person.DisplayInfo();
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
