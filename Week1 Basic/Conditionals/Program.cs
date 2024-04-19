// See https://aka.ms/new-console-template for more information

/*
Control Flow - fundamental aspect of programming in which the developer adds in concepts 
    to further gain control over what will or will not happen within the program...and/or how often.
    - Often a Condition/Check is used to assess whether or not a chunk of code will proceed.
        - Condition -> Boolean Expression -> Any statement that evaluates to true/false
            - Examples:
                - true
                - false
                - boolean variable
                - expression: number OfBooks > 5
*/

/*
Conditional Statement - evaluates a Condition to simply determine if a chunk of code is/is not executed.
    - If Statement
        - If-Else Statements
        - If-ElseIf Statements
    - Ternary Operators
    Switch-Case Statements
*/

        //put condition inside parenthesis    {} curly braces used for chunk of code / determines if executes based on bool 
bool isRainy = true;

    if (isRainy)                                
    {
        Console.WriteLine("It is Rainy outside!");
    }

//Detour = Console Input -> if you want to contribute -> Console.ReadLine(); -? pauses and waits for you to enter something in console
    Console.WriteLine("Please enter your favorite number");    //should always put statement to read before user input
    string input = Console.ReadLine();        //returns as string input
    Console.WriteLine("Your favorite number is: " + input);    //returns as string

   
//Converting Data Types
    //int number = input;    //this will not just convert type from string to integer
    //int number = int.Parse("123");  // will convert string 123 to integer 123
    //int number = int.Parse(input);    //another way to change to integer is to use variable of input


    //gets rid of yellow squiggly warning      ******Need video for this too
/*int num1 = 0;
if (input != null)     
{
    int num = int.Parse(input);
}
*/




/*   NEED RECORDING FOR THIS PART!!!!!!
int num1 = 0;
if (input != null)     
{
    int num = int.Parse(input);
}

if (num1 > 10)
{
    Console.WriteLine("Your favorite number is greater than 10 girl!);");
}



//Block code - anything inside {} can only be used inside that block
    //fails because number variable is inside 1st block of code
    // to fix put variable outside block  - up above  int number;
/*if (input != null)     
{
    int number = int.Parse(input);
}

if (number > 10)
{
    Console.WriteLine("Your favorite number is greater than 10!);")
}*/
//......................................need to go back and get all this above-------------------



int number = 0;  //we need to create the number variable outside of the IF statement for its "scope" to stretch beyond just that IF block

//Converting Data Types

if (input != null)
{
    number = int.Parse(input);
}
else
{
    Console.WriteLine("You failed to enter only digits, you suck!");
}

if (number > 10)
{
    Console.WriteLine("Your favorite number is greater than 10!");
}
else
{
    if(number == 10)
    {
        Console.WriteLine("Your favorite number is exactly 10!");
    }
    else
    {
        Console.WriteLine("Your favorite number is less than 10!");
    }
}

//Further nested
if (input != null)
{
    number = int.Parse(input);
}
else
{
    Console.WriteLine("You failed to enter only digits, you suck!");
}

if (number > 10)
{
    Console.WriteLine("Yo Your favorite number is greater than 10!");
}
else
{
    if(number == 10)
    {
        Console.WriteLine("Yo Your favorite number is exactly 10!");
    }
    else
    {
        if (number > 5)
        {
            Console.WriteLine("Yo Your favorite number is between 5 and 10");
        }
        else
        {
            Console.WriteLine("Yo Your number is <=5");
        }
    }
}


//An Alternative to (most) conditionals
//If-elseif-else statements

if (number > 10)
{
    Console.WriteLine(">10 yay!");
}
else if (number > 5)
{ 
    Console.WriteLine("5<your number <=10 .....yay...");
}
else
{
    Console.WriteLine("<=5 ...whatever...");
}


//Ternary Operators 
    //Alternative to simple If-Else Statements where the tasks/outcomes are very similar
    //has syntax: (condition) ? <option if true> : <option if false>    //way to return a value

if (number > 10)
{
    Console.WriteLine("Your number is greater than 10");
}
else
{
    Console.WriteLine("Your number is not greater than 10");
}


//Simplified Ternary Operator
string phrase = "Your number is " + ((number > 10) ? "greater than 10 goof" : "not greater than 10 goof"); //concatenated also
Console.WriteLine(phrase);


//Switch statements
    //Best used when the options we want to consider are particular, finite, and/or incremental
        // 1 2 3 4 5  vs <5 >7 etc
        //available as option to if else statement
        //simplifies how to handle exact value matches

/*
switch (variable)
{
    case(value1):
    {
        //some code to execute if variable == value1
        //break;
    }
    case(value2):
    {
        //some code to execute if variable == value2
        //break;
    }
    case(value3):
    case(value4):
    {
        //some code to execute if variable == value3 OR value4
        //break;
    }
    default:
    {
        //some code to execute if variable != to any other case
        //break;
    }
}
*/


Console.WriteLine("Enter an option 1-4: ");
input = Console.ReadLine();
int option = 0;

if(input != null)

option = int.Parse(input);

switch (option)
{
    case 1:
        Console.WriteLine("You have chosen Option 1. You win $1");
        break;
    case 2:
        Console.WriteLine("You have chosen Option 2. You win $2");
        break;
    case 3:
    case 4:
        Console.WriteLine("You have chosen Option 3 or Option 4.  You lose");
        break;
    default:    
        Console.WriteLine("You did not choose an option 1-4. Please try again");
        break;
}









//   Loops   (will need to move)
