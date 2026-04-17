using System;


// Event triggered →
// Delegate decides methods →
// All attached methods run


public delegate void ThresholdReachedHandler(int value);
//  Delegate = method reference (function pointer)
class Counter
{    public int Value {
            get; 
            set; 
            }

    //  Event
    public event ThresholdReachedHandler ThresholdReached;

    public void Increment(int threshold)
    {
        Value++;

        Console.WriteLine("Counter: " + Value);

        // Raise event
        if (Value == threshold)
        {
            ThresholdReached?.Invoke(Value);
            // firing event if not null        
        }
    }
}
class Program
{
    // Event handler 1
    static void ShowMessage(int value)
    {
        Console.WriteLine("Threshold reached at " + value);
    }

    // Event handler 2
    static void AlertUser(int value)
    {
        Console.WriteLine("Alert! Limit hit: " + value);
    }

    static void Main()
    {
        Counter counter = new Counter();

        // Subscribe handlers
        counter.ThresholdReached += ShowMessage;
        counter.ThresholdReached += AlertUser;

        int threshold = 5;

        // Loop
        for (int i = 0; i < 10; i++)
        {
            counter.Increment(threshold);
        }
    }
}


//  Method signature match aaganum
// (same return type + parameters)

// Multiple methods kooda attach panna mudiyum
