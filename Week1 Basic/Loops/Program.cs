// See https://aka.ms/new-console-template for more information
/*
Control Flow - Loops - allow us to execute a chunk of code for as long as the condition continues to be true.
    - The condition is reassessed after each "iteration" of the loop, before executing the loop again

    - While Loop
        - Do-While Loop
        - Best used when the number of iterations needed by the loop is not known / non-deterministic
    
    - For Loop
        - Foreach Loop
        - Best used when the number of interactions needed by the loop is known / calculable.  Finite.
            ex. sum of 1-100
            ex. total of salaries for employer
 */


/*
While (condition)
{
    Code to execute while condition is true
}
*/
//  NEED RECRODING FOR THIS PART
//Print the numbers 1-100
    //have to do over and over
//int counter = 1;
//Console.WriteLine(counter);
//counter++;
//Console.WriteLine(counter);



/* While Loop
while (condition)
{
    // code to execute while condition is true.
}
*/

//Print the numbers 1-100
int counter = 1;
while (counter <100)
{
    Console.WriteLine(counter);
    counter++;
}
Console.WriteLine("End of Program");






//Print the Sum of the numbers 1-100

/*counter = 1;
int end = 100;
int sum = 0;

while (counter <= end)
{
    sum += counter;
    counter++;
}
Console.WriteLine("The sum of the numbers 1-" + sum + " is: " + sum);
*/



//Print the Sum of the numbers 1-1000000

counter = 1;
int end = 1000000;
long sum = 0;

while (counter <= end)
{
    sum += counter;
    counter++;
}
Console.WriteLine("The sum of the numbers 1-" + sum + " is: " + sum);


//Monday 4/22

// Input Validation

    // Tell the user to print out the number: 5  example
   /*
    Console.WriteLine("Please input the number: 5.");
    string? input = Console.ReadLine();

    int num = 0;

    if (input != null) num = int.Parse(input);

    if (num == 5)
    {
        Console.WriteLine("Good Job!  You followed the instructions!.");
    }
    else
    {
         Console.WriteLine("How hard could this be??? Please enter a number");
    }  
    */

    //rebrand example in While Loop
      //  Will not ALWAYS enter While Loops (ex. if number guessed first)
    /*
    int num = 0;
    num = 0;
    while(num!=5)
    {
        Console.WriteLine("Please input the number: 5.");
        string? input = Console.ReadLine();
        if (input != null) num = int.Parse(input);
    if (num != 5)
    {
        Console.WriteLine("Please try again.");
    }

    }
    Console.WriteLine("You finally got it correct!  You entered: " + num );
*/


//Do-While Loop

    // Serves good purpose in input validation
    // Do-While Loops, as opposed to just while loops, 

    /*
    do
    {
        //whatever we want loop to do
    }
    while (condition);


    */

    //Rebranding the last example into a do-while loop
        //always executes the do-while loop at least once
    int num = 0;
    num = 0;
    
    do
    {
       Console.WriteLine("Please input the number: 5.");
        string? input = Console.ReadLine();
        if (input != null) num = int.Parse(input); 
        
        if (num !=5)
        {
             Console.WriteLine("Do: Please try again.");
        }
    }
    while (num != 5);
    Console.WriteLine("Do: You finally got it correct!  You entered: " + num );





//For Loop
    //Best used when the number of iterations is known / calculable


    /*
    for (initialization; condition; update)  //for loop header or for loop signature
        //can declare variable  / Update executed at end of iteration - update occurs - then checked again
    {

    }


    */

//Print the number 1-100   

for(int count = 1; count <=100; count++)   //start at 1 - go until it hits 100 - increment
{
    Console.WriteLine(count);
}


//Print the sum of variables 1-10000
int result = 0;
for(int count = 1; counter <=10000; count++)
{
    result += counter;
}
    Console.WriteLine(result);


//Practice
//Print only even numbers 2-200

for(int i = 2; i <=200; i += 2)
{
    Console.WriteLine(i);
}


//Print all numbers starting with 50 going to 25
for(int i = 50; i >= 25; i--)   
{
    Console.WriteLine(i);
}



//Nesting Loops
/*
    - Any control flow can put coded / nested into any other control flow.
            - Therefore Loops can be build inside other loops
            - However, we should exercise caution
                - could potentially develop scenario that will drastically increase processing time.
    - Problem: 
            - Single Loops -> 100 iterations -> 100 Processes
            - Nested Loop -> 100 iterations inside 100 iterations -> 10,000 Processes
            - Quadratic Growth of Time
*/



//Build a square out of '*' of whatever size we want
int size = 4;

for (int i = 1; i <= size; i++)
{
    for(int j = 1; j <=size; j++)
    {
        Console.Write("*");  // all on same line
    }
        Console.WriteLine("");
}


Console.WriteLine("break");
//Staircase Challenge
//Print 1 '*' for the 1st row.  Then 2 "*" for the 2nd row, etc

size = 5;

// The out loop deals with printing additional rows / steps / stairs
for (int i = 1; i <= size; i++)
{
        // the inner loops deals with printing the contents of each row / steps / stairs
    for(int j = 1; j <=i; j++)
    {
        Console.Write("* ");
    }
        Console.WriteLine("");
}


// Staircase challenge Continued

// There are 3 other directions that the staircase can "face"
//Build them all

/*
Right-facing
   *
  **
 ***
****

Inverted
****
***
**
*

Inverted Right facing
****
 ***
  **
   *

- Afterwards: Solve any of them with a single loop
*/

/*
//decrease
size = 5;

// The out loop deals with printing additional rows / steps / stairs
for (int i = 1; i <= size; i++)
{
        // the inner loops deals with printing the contents of each row / steps / stairs
    for(int j = 1; j <=i; j++)
    {
        Console.Write("* ");
    }
        Console.WriteLine("");
}
*/




//For Each Loop
// - Best used when the iterating (once) over each item of a collection of values.

//Before For Each
string word = "Hello";
for (int i = 0; i < word.Length; i++ )
{
    Console.WriteLine(word[i]);
} 

//--------------- separate


Console.WriteLine("FOR EACH LOOP");
//Foreach Loop
//string word = "Hello";
foreach (char c in word)   // goes over each item in collection or word - what are we referring to
{
    Console.WriteLine(c);
} 














/*
Guessing Game - Make a new project
- Start with the assumed range of numbers 1-100
- Prompt the user to Enter a number in said range
- Tell the user if the number is higher, lower, or equal to <some number of your choice>
        - If equal, they win the Guessing Game! Yay!
        - If higher or lower, let them Guess Again
        - The while loop essentially needs to contain 
                - Prompting the user
                - retrieving their guess
                - telling then higher, lower, or correct
                - while (guess != correctChoice) -> run the loop again
                - Use You won the game when correct

//Bonus   - Introduce yourself to some other libraries, to help you randomize the correct answer
//          - The sure is prompted to play again?  without having to restart your application
//                  Involved (likely) with another (outer) while loop

// Bonus Bonus:
 - Adjust the range in which you tell the user to guess based on their previous wrong answers
 - what is the lowest low guess and the lowest high guess
 - Allow the user to pick the numbers that they will guess between when the game starts

*/




