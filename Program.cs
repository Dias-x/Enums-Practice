using System;



class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Hans", Geschlecht.Männlich);

        //Ausführung "Männlich"
        Console.WriteLine($"Geschlecht: {person.Geschlecht}");
        
        //Ausführung des Wertes "0"
        Console.WriteLine($"Geschlecht: {(int)person.Geschlecht}");
    }
}

enum Geschlecht
{ 
    //Wert wird Automatisch zugewiesen 
Männlich, // -> 0
Weiblich, // -> 1
Divers    // -> 2
}


class Person
{
    public string Name { get; set; }
    public Geschlecht Geschlecht { get; set; }

    public Person(string name, Geschlecht geschlecht)
    {
        Name = name;
        Geschlecht = geschlecht;
    }
}