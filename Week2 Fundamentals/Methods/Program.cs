//Methods

using System;   //control imports - additional code - can use other imports

class Program       //
{
    static void Main(string[] args)    //main method - previously generated -> Method signature
    {
        // Main method code here

        Console.WriteLine("Hello People");

        /*

        Problem: Often we have chunks of code that perform some operation that we'd like to potentially use again later in our program.

            - Right now, our only means to do this is to simply copy/paste that chunk of code to repeat its intended functionality.
        
        Methods - Allow us to recall a chunk of code all consolidated to one place as often as we'd like, while simultaneously abstracting away the implementations behind achieving such fiunctionality, 
            allowing us to focus solely on the intention of said chunk of code.

        */

        AddNumbers(4, 5);  //calling the method
        AddNumbers(6,10);
    }

        //Let's make a method that simply Adds Two Numbers together (and prints that )
        
        // Method Signature Syntax:  
                //access_modifier    return_type    MethodName(parameterType  parameterName)   // return_type void means return no return data

                //methods not defined at the top - top to bottom - compiled language - compiles the definitions BEFORE executing code
            //The whole below thing is the method - adding the numbers AND printing
        public static void AddNumbers(int num1, int num2)                   //public can be used anywhere   //  void does not return any info
        {
            int result = num1 + num2;   
            //OR
            Console.WriteLine(num1 + num2);
        }







}           

