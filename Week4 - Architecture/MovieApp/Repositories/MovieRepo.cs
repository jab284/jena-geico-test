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

}