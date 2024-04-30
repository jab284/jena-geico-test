using System.Net;

class Calculator

/*
Polymorphism -> Many forms -> an entity can exist with multiple labels attached to it all at the same time.

Static Polymorphism - Overloading  - static means unchanging
    - We can have multiple methods with the same name
    - The only requirement is that they each have unique set of parameters
        * change the quantity
        * change the type
        * change the order

Dynamic Polymorphism - Overriding - decisions could be changed during execution or run time
    - We can change the implementation of the methods that we inherit into a new Child Class to fit the narrative of our new class.
        * C# requires you to specify that a method can be overridden - virtual  (can be overridden)
        * and by extension, you must explicitly declare that you are overriding an implementation - override  (are overriding)


*/
//Both versions of this method can exist at the same time.
//Because C# can identify which version of the Add() we want to use at any given moment

{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    /* Cannot have another overloaded with the exact same params.  (same as Add 2 ins)
    
    public static int Add(int value2, int value4)
    {
        return value2 + value4;
    }
    */

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

    public static double Add(string num1, string num2)
    {
        return double.Parse(num1) + double.Parse(num2);
    }

     public static double Add(string num1, double num2)
    {
        return double.Parse(num1) + num2;
    }

    public static double Add(double num1, string num2)
    {
        return num1 + double.Parse(num2);
    }


    //ARRAY
    public static int Add(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }

    /*
    Params -> parameter array argument.
        * Essentially lets you provide a variable number of arguments to satisfy this one parameter, 
            in which it will 'collect' them into one array for us.
        * You can only have 1 parameter array per method
        * It MUST be the last parameter in the method

        ** You can have multiple arrays - but only 1 Parameter array  (uses params keyword)

    */
    public static double Add(params double[] array)
    {
        double sum = 0;
        foreach (double num in array)
        {
            sum += num;
        }
        return sum;
    }


}