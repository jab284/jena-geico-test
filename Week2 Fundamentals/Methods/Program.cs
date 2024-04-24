//Methods




using System.Diagnostics;

class Program       
{
    static void Main(string[] args)    //main method - previously generated -> Method signature
    {  
        
        // Main method code here

        /*
        Problem: Often we have chunks of code that perform some operation that we'd like to potentially use again later in our program.

            - Right now, our only means to do this is to simply copy/paste that chunk of code to repeat its intended functionality.
        
        Methods - Allow us to recall a chunk of code all consolidated to one place as often as we'd like, while simultaneously abstracting away the implementations behind achieving such fiunctionality, 
            allowing us to focus solely on the intention of said chunk of code.
        */

        AddNumbers(4, 5);  //calling the method   / does not "do" anything unless you do a print inside the method
        AddNumbers(6,10);
        AddNumbers(7, 10);

        
        SquareNumber(7);  //only one argument   // does not store    //ask ryan why cant do both
        
        int result = SquareNumber(5);   //this is storing
        System.Console.WriteLine(result);
        

        //Print out this message - Steps for SayHello
        /*
        System.Console.WriteLine("Please enter your name: ");
        string? input = Console.ReadLine();
        System.Console.WriteLine("===========");
        System.Console.WriteLine("Hello Everyone");
        System.Console.WriteLine("============");
        */
        SayHello();  // this is method


        //examples of storing / doing something vs not doing something
        /*
        string input = Console.ReadLine();  //this stores the value
        Console.ReadLine();   //does not do anything or store anything - just means go to console and get User input
        */

            //change to a method - use the shortcut
        System.Console.WriteLine("Welcome To Our App!");
        System.Console.WriteLine("===================");
        System.Console.WriteLine("Please Enter a Command");
        System.Console.WriteLine("[1] Say Hello!");
        System.Console.WriteLine("[2] Add Two Numbers");
        System.Console.WriteLine("[3] Square a Number");
        System.Console.WriteLine("======================");

        //make new method
        string? input = Console.ReadLine();
        int cmd = 0;
        if(input != null) cmd = int.Parse(input);

        switch (cmd)
        {
            case 1:
            {
                SayHello();
                break;
            }
            case 2:
                {
                    ProcessAddNumbers();
                    break;

                }
            case 3:  ///need rest of this
            {
                System.Console.WriteLine("Enter a Number");
                string? value1 = Console.ReadLine();

                int num1 = 0;
                if(value1 != null) num1 = int.Parse(value1);
                
               System.Console.WriteLine(SquareNumber(num1));
               break;
            }
        }
    }

    private static void ProcessAddNumbers()
    {
        System.Console.WriteLine("Enter 1st Number: ");
        string value1 = Console.ReadLine();
        System.Console.WriteLine("Enter 1st Number: ");
        string value2 = Console.ReadLine();

        int num1 = 0, num2 = 0;
        if (value1 != null) num1 = int.Parse(value1);
        if (value2 != null) num1 = int.Parse(value2);

        AddNumbers(num1, num2);
    }

    //Let's make a method that simply Adds Two Numbers together (and prints that )

    // Method Signature Syntax:  
    //access_modifier    return_type    MethodName(parameterType  parameterName)   // return_type void means return no return data

    //methods not defined at the top - top to bottom - compiled language - compiles the definitions BEFORE executing code
    //The whole below thing is the method - adding the numbers AND printing
    public static void AddNumbers(int num1, int num2)                   //public can be used anywhere   //  void does not return any info
        {
            //int result = num1 + num2;   
            //OR
            Console.WriteLine(num1 + num2);
        }
        


/* --------- 4/24 -----------*/

    //Lets make a method that RETURNS the squared value of a number.  Square a number is multiply the number by itself ex 5*5

            public static int SquareNumber(int num1)   // specific return type is int -- not void  //created the method for how square number works
            {
                int square = num1 * num1;   //calculated the square
                return square;        //return - returns the value of the method   / can be reused with "return" somewhere else (get this from recording)
                
            }



    // Welcome message Method
            public static void SayHello()
            {
                System.Console.WriteLine("Please enter your name: ");
                string? input = Console.ReadLine();
                System.Console.WriteLine("===========");
                System.Console.WriteLine("Hello, " + input);
                System.Console.WriteLine("============");
            }


//Homework - Practice Methods
//Takes in two strings and print both of them twice
//Find the largest number between 3 ints

}