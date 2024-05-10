class MovieService
{
    /*
        Services:
            - Checkout Movie
            - Check in Movie
            - Get (Your) Checked out Movies
            - Get All Available Movies

        Trivial Services:
            - Remember why we organize our application into Layers.
                - It allows us to organize and clearly conceptualize the flow of operations
                within the app at any given moment of time
            - We like to have the app ALWAYS flow Up and Down one Layer at a time!
    */

    MovieRepo mr = new();

    // m is the movie we want to attempt to check out.
    public Movie Checkout(Movie m)
    {
        //Lets first check to see if the Movie is Available 
        //- OR lets return null if its not available - get that out of the way.
        if (!m.Available)
        {
            System.Console.WriteLine("Movie Currently Unavailable");
            return null; //Movie does not get checked out
        }

        //Happy Path Execution -> Movie is good to go - can be checked out.
        //What does it actually mean to check out the movie?
        // 1) the movie becomes unavailable
        // 2) a returnDate is set.
        // 3) (Optional) - its set to a particular user.
        m.Available = false;
        // m.ReturnDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + (60 * 60 * 48);
        m.ReturnDate = DateTimeOffset.UtcNow.AddDays(2).ToUnixTimeSeconds();

        // Make sure to update the data storage with these changes.
        mr.UpdateMovie(m);

        return m; //I am choosing to send back the checked out movie. Your choice.
    }

    public List<Movie> GetAvailableMovies()
    {
        //Get All Movies
        List<Movie> allMovies = mr.GetAllMovies();

        //Then Filter out movies you dont want.
        List<Movie> availableMovies = new();
        //run a loop over all movies to determine if they make the cut - to be added to the filtered list.
        foreach (Movie m in allMovies)
        {
            if (m.Available)
            {
                availableMovies.Add(m);
            }
        }

        //Return that filtered list.
        return availableMovies;
    }

}