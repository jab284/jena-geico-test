class Parent
{
    public string JobTitle {get; set; }





    public Parent()
    {
        JobTitle = "";
    }

public Parent(string jobTitle)
{
    JobTitle = jobTitle;
}

//Method
/*public void Work()  //void
{
    System.Console.WriteLine("Work hard all day to make money. Yay!");
}*/

public virtual void Work() //not void
{
    System.Console.WriteLine("Work hard all day to make money at my job as a: "+ JobTitle);
}

 public override string ToString()
    {
        return "{jobTitle:'" + JobTitle + "'}";
        
    }


}