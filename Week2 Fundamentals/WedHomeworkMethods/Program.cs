
using System;

class Program
{
    static void Main(string[] args)
    {
        // Main method code here


        string phrase1;
        string phrase2;

        TwicePhrase(out phrase1, out phrase2);




        //Find larger number

        /*   These are the steps to create the method
        int num1 = 30;
        int num2 = 20;
        int num3 = 10;

        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine(num1);
        }
        else if (num2 >= num1 && num2 >= num3)
        {
          System.Console.WriteLine(num2);
        }
        else
        {
       System.Console.WriteLine(num3);
        }*/

        int num1 = 30;
        int num2 = 20;
        int num3 = 10;

        largestNumber(num1, num2, num3);

    }

    private static void largestNumber(int num1, int num2, int num3)
    {
        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("The largest number is: " + num1);
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            System.Console.WriteLine("The largest number is: " + num2);
        }
        else
        {
            System.Console.WriteLine("The largest number is: " + num3);
        }
    }

    private static void TwicePhrase(out string phrase1, out string phrase2)
    {
        phrase1 = "Good afternoon. ";
        phrase2 = "Coding is hard!";

        Console.WriteLine(phrase1 + phrase2);
        Console.WriteLine(phrase1 + phrase2);
    }
}
