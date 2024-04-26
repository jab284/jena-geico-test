namespace Media
{
    class TvShow
    {
        public string Title { get; set; }
        public int Rating { get; set; }

        //constructor - No Aug
        public TvShow()
        {
            string Title = "";
        }

        //Constructor - Full Aug
        public TvShow(string title, int rating)
        {
            Title = title;
            Rating = rating;
        }
    }
}