using System;

class Person
{
    // Properties
    public string Name { 
        get;
        set;          
    }
    public int Age { 
        get; 
        set; 
    }

    public void Introduce()
    {
        Console.WriteLine("Hi, my name is " + Name + " and I am " + Age + " years old.");
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person();
        p1.Name = "Akshaya";
        p1.Age = 20;

        Person p2 = new Person();
        p2.Name = "Rahul";
        p2.Age = 22;

        p1.Introduce();
        p2.Introduce();
    }
}