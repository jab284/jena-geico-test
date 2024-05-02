using System;

class Program
{
    static void Main(string[] args)
    {
        
int[] intArray = { 10, 324, 45, 90, 9808 };

int min = intArray[0]; // Initialize max with the first element of the array

foreach (int value in intArray)
{
    if (value < min)
        min = value; // Update max if the current value is greater
}

Console.WriteLine("Min number is " + min);
    }
}







