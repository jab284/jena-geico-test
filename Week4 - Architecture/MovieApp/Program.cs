using System;

class Program
{
    static void Main(string[] args)
    {
        // Main method code here
        MovieRepo mr = new();

        //Lets test retrieving a movie that exists
        //We have to make a little bit of assumption
        //The user has to know what kind of IDs might work
        System.Console.WriteLine("Please enter a movie ID: ");
        int input = int.Parse(Console.ReadLine() ?? "0");
        Movie retrievedMovie = mr.GetMovie(input);
        //Easiest way to showcase what Movie retrieved is to just print it out
        System.Console.WriteLine("Retrieved Movie: " + retrievedMovie);



        //Lets test out adding a new movie into our collection
    }
}
