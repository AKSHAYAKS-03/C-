using System;
using System.Collections.Generic;
using System.Linq;
//Language Integrated Query
//query collections like arrays, lists, or databases directly using C# syntax.
class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Sample data
        List<Student> students = new List<Student>()
        {
            new Student { Name = "Akshaya", Grade = 35, Age = 20 },
            new Student { Name = "Rahul", Grade = 70, Age = 21 },
            new Student { Name = "Priya", Grade = 40, Age = 19 },
            new Student { Name = "Arun", Grade = 60, Age = 22 }
        };

        Console.Write("Enter minimum grade: ");
        int threshold = int.Parse(Console.ReadLine());

        // LINQ: Filter + Sort
        var filtered = students.Where(s => s.Grade > threshold);

        var result = filtered.OrderBy(s => s.Name);

        Console.WriteLine("\nFiltered & Sorted Students:");

        foreach (var s in result)
        {
            Console.WriteLine(s.Name + " | Grade: " + s.Grade + " | Age: " + s.Age);
        }
    }
}