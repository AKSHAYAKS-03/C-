using System;
using System.Collections.Generic;
using System.Linq;

public interface IRepository<T>
{
    void Add(T item);
    List<T> GetAll();
    void Update(int id, T item);
    void Delete(int id);
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Repository<T> : IRepository<T> where T : class
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public List<T> GetAll()
    {
        return items;
    }

    public void Update(int id, T newItem)
    {
        var oldItem = items[id];
        items[id] = newItem;
    }

    public void Delete(int id)
    {
        items.RemoveAt(id);
    }
}

class Program
{
    static void Main()
    {
        Repository<Student> repo = new Repository<Student>();

        repo.Add(new Student { Id = 1, Name = "Akshaya" });
        repo.Add(new Student { Id = 2, Name = "Rahul" });

        Console.WriteLine("All Students:");
        foreach (var s in repo.GetAll())
        {
            Console.WriteLine(s.Id + " " + s.Name);
        }

        // Update
        repo.Update(0, new Student { Id = 1, Name = "Updated Akshaya" });

        // Delete
        repo.Delete(1);

        Console.WriteLine("\nAfter Update & Delete:");
        foreach (var s in repo.GetAll())
        {
            Console.WriteLine(s.Id + " " + s.Name);
        }
    }
}

// Interface	rules
// Generic	reusable
// Repository	data manager