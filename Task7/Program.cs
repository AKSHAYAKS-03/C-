using System;
using System.Threading.Tasks;

class Program
{
    // Task (Class)later returns a string value
     
    static async Task<string> GetData1()
    {
        await Task.Delay(2000); 
        return "Data from API 1";
    }

    static async Task<string> GetData2()
    {
        await Task.Delay(3000);
        return "Data from API 2";
    }

    static async Task<string> GetData3()
    {
        await Task.Delay(1000);
        return "Data from API 3";
    }

    static async Task Main()
    {
        try
        {
            Task<string> t1 = GetData1();
            Task<string> t2 = GetData2();
            Task<string> t3 = GetData3();

            string[] results = await Task.WhenAll(t1, t2, t3);
            // Run all tasks → wait → collect all outputs into array
            Console.WriteLine("All results:");

            foreach (var r in results)
            {
                Console.WriteLine(r);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}