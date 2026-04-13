using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "input.txt";
        string outputFile = "output.txt";

        try
        {
            string text = File.ReadAllText(inputFile);
            // Reads full file content as string
            int wordCount = text.Split(' ', '\n').Length;
            int lineCount = File.ReadAllLines(inputFile).Length;
            // Read lines

            string result = "Word Count: " + wordCount + "\nLine Count: " + lineCount;

            // Write to output file
            File.WriteAllText(outputFile, result);

            Console.WriteLine("Processing completed! Check output.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found!");
        }
        catch (IOException)
        {
            Console.WriteLine("Error: File issue occurred!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }
}