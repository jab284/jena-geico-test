namespace Media
{
    
    public int  namespaceNum = 10;
    class Movie
    {
        public string Title { get; set; }
        public int Rating { get; set; }
        public double Price { get; set; }

        //constructor - No Aug
        public Movie()
        {
            string Title = "";
        }

        //Constructor - Full Aug
        public Movie(string title, int rating, double price)
        {
            Title = title;
            Rating = rating;
        }
    }


}