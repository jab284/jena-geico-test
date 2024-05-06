using System;
using System.ComponentModel;
using System.Linq.Expressions;


class Program
{
    static void Main(string[] args)
    {
        //PreventativeApproach();

        //HandleStackTraceMethod();

        HandleTwoTryCatchMethod();
        try
        {
            ThrowingExceptions();
        }
        catch (NoFunException e)
        {
            System.Console.WriteLine(e.Message);
        }
       






    }


    public static void ThrowingExceptions()
    {
        System.Console.WriteLine("Enter a number between 1-100");
        int guess = int.Parse(Console.ReadLine() ?? "0");

        int correct = 50;

        if (guess == correct)
        {
            System.Console.WriteLine("You got it correct.");
        }
        else if (guess > correct)
        {
            System.Console.WriteLine("Your guess is too high");
        }
        else if (guess < correct && guess > 0)
        {
            System.Console.WriteLine("Your guess is low.");
        }
        else
        {
            throw new NoFunException("I guess you aren't having fun anymore! Goodbye!");
        }



    }
    
    public static int WhyFinally()
    {
        int x = 10;
        int y = 1;

        try
        {
            int result = x / y;
            return result;
        }
        catch (DivideByZeroException e)
        {
                System.Console.WriteLine(e.Message);
                return 0;
        }
        finally
        {
            System.Console.WriteLine("Printing from the Finally Block");
        }
        //System.Console.WriteLine("Printing from the End of the Method");
    }


    private static void HandleTwoTryCatchMethod()
    {
        //Handling 2 exceptions Invalid Input showing stacktrace error
        int[] numbers = [7, 8, 9];

        System.Console.WriteLine("Enter an index");

        string input = Console.ReadLine() ?? "0"; //Null Coalescing - Handles if null


        //Handling Exceptions: try-catch block
        try
        {
            int index = int.Parse(input);
            System.Console.WriteLine(numbers[index]);
        }
        catch (IndexOutOfRangeException e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
        }
        catch (FormatException e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);

        }
        finally
        {
            System.Console.WriteLine("will execute no matter what!");
        }

        System.Console.WriteLine("Program Ends");
    }

    private static void HandleStackTraceMethod()
    {
        //Handling Approach showing stacktrace error
        int[] numbers = [4, 5, 6];

        System.Console.WriteLine("Enter an index");

        int index = int.Parse(Console.ReadLine() ?? "0"); //Null Coalescing - Handles if null


        //Handling Exceptions: try-catch block
        try
        {
            System.Console.WriteLine(numbers[index]);
        }
        catch (IndexOutOfRangeException e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
        }

        System.Console.WriteLine("Program Ends");
    }

    private static void PreventativeApproach()
    {
        int[] numbers = [1, 2, 3];

        //int index = 3;  // outside range and gives error / exception
        // Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

        System.Console.WriteLine("Enter and index: ");
        int index = int.Parse(Console.ReadLine() ?? "0"); //Null Coalescing - Handles if null


        // Preventative Approach to dealing with issues / errors
        if (index >= numbers.Length || index < 0)  //.Length is the length of array
        {
            System.Console.WriteLine("You failed to enter index in range.");
        }
        else
        {
            System.Console.WriteLine(numbers[index]);
        }

        //System.Console.WriteLine(numbers[index]);

        System.Console.WriteLine("Program ends");
    }
}
