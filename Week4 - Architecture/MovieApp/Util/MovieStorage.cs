class MovieStorage
{
    /* 
    This ENTIRE Setup is TEMPORARY!
    We do not know how to work with the Databases yet
    - by extension - communicate with them

    SO we are going to build some devices for Storing Movies.
    BUT everything is sadly lost every time the application shuts down
    */

    public Dictionary<int, Movie> movies;  //maps to Movie
    public int idCounter = 1; 


    //Constructor - give us preloaded Movies to work with
    public MovieStorage()
    {
        Movie movie1 = new(idCounter, "Iron Man", 5, true, 0); idCounter++;
        Movie movie2 = new(idCounter, "The Flash", 6, true, 0); idCounter++;
        Movie movie3 = new(idCounter, "Ant_Man", 4, true, 0); idCounter++;

          
       
        movies = [];     // Sets the Dictionary to an empty collection
        movies.Add(movie1.Id, movie1);
        movies.Add(movie2.Id, movie2);  
        movies.Add(movie3.Id, movie3);


    }

}