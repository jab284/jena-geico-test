// See https://aka.ms/new-console-template for more information


//JEN'S GUESSING GAME



Random random = new Random();
int answer = random.Next(1, 100);

//int answer = 28;
int guessCount = 0;  
int guess = 0;


Console.WriteLine("Let's play my Guessing Game");
Thread.Sleep(2000);
Console.WriteLine("I am going to pick a number between 1 and 100.");
Thread.Sleep(2000);
Console.WriteLine("Thinking of a number...");
Thread.Sleep(3000);
Console.WriteLine("I'm ready.  Pick a number to see if you can guess what my number is.");




while (guess != answer)
{
    string input = Console.ReadLine();  

    guess = int.Parse(input);  


    if (guess > 100)
    { 
        Console.WriteLine("Whoah there, I said pick a number between 1 and 100!  How about you try again?");
    }

    else
        {
            if (guess < answer)
                {
                    guessCount++;
                    Console.WriteLine("Sorry, my number is higher than your guess.  Please try again.");
                }
            else if (guess > answer)
                 
                    //if (guess > answer)
                    {
                        guessCount++;
                        Console.WriteLine("No luck.  My number is lower than your guess.  Please try again.");
                    }
            //else //(guess == answer)
                //{
                    //guessCount++;
                    //Console.WriteLine("Way to go!.  You win.  How many guesses did it take you? Just " + guessCount + ".");
        }
}
      
    guessCount++;
    Console.WriteLine("Way to go!.  You win.  How many guesses did it take you? Just " + guessCount + ".");
    Console.WriteLine("Thanks for playing!  Hope you enjoyed the game.");







