class House : Building  //Child class with parent class
{
    public int Bedrooms { get; set; }
    public string? Owner { get; set; }
    public House () : base() //base()
    {
        System.Console.WriteLine("Now let's make a Building into a House.");

    }

    public House(int walls, int area) : base(walls, area)  //does same as building constructor
    {
        Owner = "";
        System.Console.WriteLine("Now let's make that building with area and walls into a house.");
    }

    //public House(int walls, int area, int bedrooms, string owner)  ** easy part
    public House(int walls, int area, int bedrooms, string owner) : base(walls, area)
    {
        //easy part
        /*Walls = walls;
        Area = area;
        Bedrooms = bedrooms;
        Owner = owner*/
       
        Bedrooms = bedrooms;
        Owner = owner;


    }

    public override string ToString()
    {
        return "{walls:" + Walls + ",area:" + Area + ",bedrooms:" + Bedrooms + ",owner:'" + Owner + "'}";
    }

    

}