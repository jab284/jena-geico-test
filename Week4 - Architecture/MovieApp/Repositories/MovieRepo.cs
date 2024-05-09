class MovieRepo
{
    /*
    This class is in the Data Access / Repository Layer of the application.
    Solely responsible for any dta access and management centered around our Movie Object

    4 Major Operations we would like to manage in this location.
        * CRUD Operations
            - C - Create    //
            - R - Read      //
            - U - Update    // Changes to make to database
            - D - Delete    //Removal of any objects

    */

    MovieStorage movieStorage = new();

    public Movie AddMovie(Movie m)  //use most info available (Movie)
    {
        // Need to first ensure movie being added has correct ID.
        //Assume it does not...and force it to have a correct ID using IdCounter
        m.Id = movieStorage.idCounter++;  //incrementing the value afterwards to prep it for the next time it is needed

        //Add the movie into our collection
        movieStorage.movies.Add(m.Id, m);
        return m;
    }

    public Movie? GetMovie(int id)
    {
        if (movieStorage.movies.ContainsKey(id))
        {
        Movie selectedMovie = movieStorage.movies[id];
        return selectedMovie;
        }
        else
        {
            return null;
        }
    }


    public Movie ? UpdateMovie(Movie updatedMovie)
    {
        //Assuming that the ID is consistent with an ID that exists
        //then we just have to update the calue for said ID(key) within the Dictionary
        try
        {
        movieStorage.movies[updatedMovie.Id] = updatedMovie;

        //I choose to send the updated Movie back as a "response-feedback" system.
        //Here is me telling you I have updated storage with this movie I sent back to you
        return updatedMovie;
        }
        catch(Exception)
        {
            System.Console.WriteLine("Invalid Movie ID - Please Try Again");
            return null;
        }
    }

    public Movie ? DeleteMovie(Movie m)
    {
       
       
        //If we have ID -> Remove it from storage
        bool didRemove = movieStorage.movies.Remove(m.Id);

            if(didRemove)
            {
                // How do I get this to return the movie that was just removed?
                return m;
            }
            else
            {
                 System.Console.WriteLine("Invalid Movie ID - Please Try Again");
                return null;
            }
    }
        

        
    


}