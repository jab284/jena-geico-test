using System.Data.Common;
using System.Diagnostics.Contracts;

class Movie
{
    public int Id;
    public string Title { get; set; }
    public double Price { get; set; }
    public bool Available { get; set; }
    public long ReturnDate { get; set; }


    //Base constructor
    public Movie()
    {
        Title = "";
    }

    //Full Constructor
    public Movie(int id, string title, double price, bool available, long returnDate)
    {
        Id = id;
        Title = title;
        Price = price;
        Available = available;
        ReturnDate = returnDate;
    }

    public override string ToString()
    {
        return "{id:" + Id 
        + ",title:" + Title 
        + ",price:" + Price 
        + ",available:" + Available 
        + ",returnDate:" + ReturnDate 
        + "}";
    }

}