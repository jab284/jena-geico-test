using System;

class Program
{
    static void Main(string[] args)
    {
        // Main method code here
        MovieRepo mr = new();

        RetrievingMovie(mr);  //Tested the MovieRepo - GetMovie()



        //Lets test out adding a new movie into our collection
        AddingNewMovie(mr);

        //Lets test updating a movie in our collection
        UpdatingMovie(mr);

        //Lets test deleting a movie
        DeletingMovie(mr);


    }


    public static void DeletingMovie(MovieRepo mr)
    {
       //Pick a Movie -> Ask for and ID of a Movie -> Retrieve the Movie with that ID
        Movie movie = PromptUserForMovie(mr);
        //Remove that movie from storage
        System.Console.WriteLine("Delete Movie: " + mr.DeleteMovie(movie));
    }

    private static void UpdatingMovie(MovieRepo mr)
    {
       // Pick a movie -> Ask for an ID of a Movie ->Retrieve the movie with that ID
        Movie movie = PromptUserForMovie(mr);
       //Let the user update some fields
       System.Console.WriteLine("Please provide a new Title: ");
       movie.Title = Console.ReadLine() ?? "";
       // we could add more steps to update more values

       // Save those changed values to our storage
       //mr.UpdateMovie(movie);
       System.Console.WriteLine("Updated Movie: " + mr.UpdateMovie(movie));
      
    }

    private static void AddingNewMovie(MovieRepo mr)
    {
        System.Console.WriteLine("Let's Add in a new Movie");
        System.Console.WriteLine("Please provide a Movie Title: ");
        string? title = Console.ReadLine();

        System.Console.WriteLine("Please enter a price: ");
        double price = double.Parse(Console.ReadLine() ?? "0");

        //Let's assume that the Available will default to true
        //and by extension the returnDate will be 0.

        //Also not going to ask them for an ID - becuase our MovieRepo - AddMovie()
        //already gives it the next, correct value fir ID.

        //Now we need to collect all of this information into a new Movie Object
        Movie movie = new(0, title, price, true, 0);  //temp device to hold and then fed into movie below

        //Now that the information is collected into Movie Object
        //let's use the MovieRepo to ADD it to our data storage.
        movie = mr.AddMovie(movie);  //fed in from above variable
        //I am reusing the movie variable to store the updated values, if any, 
        //from the AddMovie() process.

        //For the sake of Clarity to the User of the App, let's inform them
        //of the newly added movie.
        System.Console.WriteLine("Newly Added Movie: " + movie);

    }

    private static void RetrievingMovie(MovieRepo mr)
    {
        //Movie? retrievedMovie = null;
        //while (retrievedMovie == null)
        

            //Lets test retrieving a movie that exists
            //We have to make a little bit of assumption
            //The user has to know what kind of IDs might work
            
            /*System.Console.WriteLine("Please enter a movie ID: ");
            int input = int.Parse(Console.ReadLine() ?? "0");
            retrievedMovie = mr.GetMovie(input);  */
            Movie retrievedMovie = PromptUserForMovie(mr);
        
        //Easiest way to showcase what Movie retrieved is to just print it out
        System.Console.WriteLine("Retrieved Movie: " + retrievedMovie);
    }

    private static Movie PromptUserForMovie(MovieRepo mr)
    {
        //Now we have input validation
        Movie? retrievedMovie = null;
        while (retrievedMovie == null)
        {

            System.Console.WriteLine("Please enter a movie ID: ");
            int input = int.Parse(Console.ReadLine() ?? "0");
            retrievedMovie = mr.GetMovie(input);
        }

        return retrievedMovie;
    }
}
