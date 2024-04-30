class Child : Parent
{
    public string FavoriteGame {get; set;}




    //No Arg COnstructor
    public Child()
    {
        FavoriteGame = "";
    }

    //Constructor
    public Child(string jobTitle, string favoriteGame) : base(jobTitle)
    {
        FavoriteGame = favoriteGame;
    }

    //Method
    public void Play()
    {
        System.Console.WriteLine("Playing my favorite game: " + FavoriteGame);
    }

    //This is now an overridden method which changes its implementation for the for this Class ONLY
    public override void Work()
    {
        
        {
            System.Console.WriteLine("Doing my homework to get good grades!");
        }
    }
}