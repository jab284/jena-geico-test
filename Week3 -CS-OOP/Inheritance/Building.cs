class Building
{
    public int Walls { get; set; }
    public int Area { get; set; }
    

//No Arg Constructor
    public Building()
    {
        //for purpose of demo
        System.Console.WriteLine("Constructing a new building");
    }

    public Building(int walls, int area)
    {
        Walls = walls;
        Area = area;
        System.Console.WriteLine("Constructing a new building with " + walls + " walls and "+ area + "area.");
    }
    public override string ToString()
    {
        return "{walls:" + Walls + ", area:" + Area + "}";
    }
}
