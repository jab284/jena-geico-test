using System.Drawing;

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



/*
Constructors - a special type of method whose purpose is to help us create new objects of that class.
    Along with any other initial set up instructions we wish to provide.

    Syntax:
    access_modifier ClassName(potential parameters)
    {
        //what you want the constructor to do while setting up your object.
            - setting initial values is common
    }

    C# will provide a "default" constructor when you do not explicitly create any constructors.
        - As soon as you create even ONE constructor, the default constructor is no longer provided.

*/

//Constructor Method - almost always public
    //constructor builds basic process

    //No Arg Constructor
public Car()    //public (access modifier) and Car() (name of class)    Car() - no value constructor / no argument constructor
{
    color = "Black";    //sets default value
}

//We can have multiple constructors - the only requirement is that the parameters have to be some new unique combination of types.
//Overloaded Methods -> Have multiple implementations to the same named method - with different parameters
//ex
public Car(string color)
{
    //color = newColor;
    //System.Console.WriteLine(color);  //references the other method"Silver"

    //don't have to use
    this.color = color;  //this is placeholder - represents object in reference  ex car being driven - must match class name
    System.Console.WriteLine(color);
}

//Full argument constructor Full-Arg - meaning choice of us providing ALL the values for our fields
    //make them easy as possible - makes life convenient
public Car(string color, string make, string model, int year, int mileage)
{
    this.color = color;
    this.make = make;
    this.model = model; 
    this.year = year;
    this.mileage = mileage;
}

//Bonus
//Copy Cponstructor
public Car(Car other)
{
    color = other.color;
    make = other.make;
    model = other.make;
    year = other.year;
    mileage = other.mileage;
}


//METHODS
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


/*
public string DisplayInfo()   //to override
{
    string str = "";
    str +="{Color=" + color;
    str +="; Make=" + make;
    str +="; Model=" + model;
    str +="; Year=" + year;
    str +="; Mileage=" + mileage + "}";
    return str;
}
*/

public override string ToString()   //to override the DisplayInfo() method
{
    string str = "";
    str +="{Color=" + color;
    str +="; Make=" + make;
    str +="; Model=" + model;
    str +="; Year=" + year;
    str +="; Mileage=" + mileage + "}";
    return str;
}






}