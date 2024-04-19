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
*/