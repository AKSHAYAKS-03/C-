using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> items = new List<string>();
        int choice;

        do
        {
            Console.WriteLine("\n1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Display Items");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter item: ");
                    string item = Console.ReadLine().Trim().ToUpper();
                    items.Add(item);
                    Console.WriteLine("Item added!");
                    break;

                case 2:
                    Console.Write("Enter item to remove: ");
                    string removeItem = Console.ReadLine().Trim().ToUpper();

                    if (items.Remove(removeItem))
                        Console.WriteLine("Item removed!");
                    else
                        Console.WriteLine("Item not found!");
                    break;

                case 3:
                    Console.WriteLine("\nItems list:");
                    if (items.Count == 0)
                    {
                        Console.WriteLine("No items available.");
                    }
                    else
                    {
                        foreach (string i in items)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 4);
    }
}