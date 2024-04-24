class Car
{
    //states and behaviors for Cars / Fields
    //variables that exist -> not assigned values
    //create fields
    public string color;
    public string make;
    public string model;
    public int year;
    public int mileage;

    

//default to private -> can make public (just type public in front of objects)

//or make a method
/*
public string GetColor()
    {
        return color;
    }
*/


//Method attached to Class of car
public void Honk()
{
    System.Console.WriteLine("Honk Honk!");
}

//

public void Drive(int milesDriven)
{
    mileage += milesDriven;
    System.Console.WriteLine("New total mileage is: " + mileage);
}




}