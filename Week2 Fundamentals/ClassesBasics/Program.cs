// See https://aka.ms/new-console-template for more information
using System;
using Media;

class Program
{
    static void Main(string[] args)
    {
        //Practice Objects
        //PracticeProperties();
        //PracticeScopes();
         PracticeNamespaces();
    }



    //NameSpace
    public static void PracticeNamespaces()
    {
        Movie movie1 = new("TheAvengers", 105, 10.50);
        System.Console.WriteLine(movie1.Title);
        System.Console.WriteLine(movie1.Rating);
        System.Console.WriteLine(movie1.Price);
    }
//good up to here




        //Practice Scopes
        public static void PracticeScopes()
        {
            //Testing out the Class Scoped variable 'count' that increments by 1 with each object created
            System.Console.WriteLine("Total Things Created: " + Thing.count);
            Thing thing1 = new();
            System.Console.WriteLine("Total Things Created: " + Thing.count);
            Thing thing2 = new();
            System.Console.WriteLine("Total Things Created: " + Thing.count);

            //Showing that Object Scoped variables are independent of one another.
            thing1.objectNum++;
            thing2.objectNum--;

            System.Console.WriteLine(thing1.objectNum);
            System.Console.WriteLine(thing2.objectNum);

            //Showing how to call Class Scoped variables/methods.
            //Cannot do so through the Objects of tht Class.
            System.Console.WriteLine(Thing.classNum);
            Thing.StaticMethod();
            System.Console.WriteLine(DateTime.Now);
            
            thing1.StaticMethod(25);
        }

        public static void PracticeProperties()
        {
            /*
            Book book1 = new Book();
            book1.SetTitle("Dracula");
            */
            Book book1 = new Book();
            book1.Title = "Dracula";                //Technically using the underlying Setter in this Property
            System.Console.WriteLine(book1.Title);  //Technically using the underlying Getter in this Property
        }

        
        
        //===================//

        
        // We put all yesterdays code here to clean it up a bit for seeing todays stuff better so can comment out at will.  Thats it
    private static void PracticeObjects()  
    {
        // Main method code here

        int num = 1;
        string word = "Hello";


        //Object Declaration and Instantiation (Initialization) - Instantiation used more when referring to Objects (new instance of class)
        Object obj1 = new Object();  //referring to object class itself and building an instance of class called object / new -> allocate memory
        Object obj2 = new Object();  //constructor replicates the name of the class or the name of the Data type Object    
        Object obj3 = new();         //assumes name of Object / method called above is same -> has to match -- don't have to do

        //Whatever is on Left - HAS to create that same thing on the right

        DateTime currentTime = DateTime.Now;   //whatever on right HAS to create something ex DateTime
        System.Console.WriteLine(currentTime);

        Car car1 = new Car();
        System.Console.WriteLine(car1);   // right now only prints the object - prints name of class only

        car1.model = "Rouge";
        car1.color = "Blue";
        car1.make = "Nissan";
        car1.year = 2021;

        System.Console.WriteLine(car1.color);
        System.Console.WriteLine(car1.make);
        System.Console.WriteLine(car1.model);

        car1.Honk();
        car1.Drive(100);
        car1.Drive(50);

        Car car2 = new();

        car2.model = "CX5";
        car2.color = "Gray";
        car2.make = "Mazda";
        car2.year = 2022;

        System.Console.WriteLine("Car 1 Mileage: " + car1.mileage);
        System.Console.WriteLine("Car 2 Mileage: " + car2.mileage);

        car2.Drive(50);
        System.Console.WriteLine("===After Driving Car 2 some more===");
        System.Console.WriteLine("Car 1 Mileage: " + car1.mileage);
        System.Console.WriteLine("Car 2 Mileage: " + car2.mileage);

        Car car3 = car2;
        System.Console.WriteLine("Car 3 Color: " + car3.color);
        System.Console.WriteLine("Car 3 Mileage: " + car3.mileage);

        //Are car3 and car2 the SAME car?  Or just borrowing the same initial values
        car3.Drive(75);
        System.Console.WriteLine("Car 2 Mileage: " + car2.mileage);
        System.Console.WriteLine("Car 3 Mileage: " + car3.mileage);
        //car3 and car2 are both the SAME exact Car in memory

        car3 = new();  //now reset to new car / like buying new car
        System.Console.WriteLine("===Car 3 being reset to a new car===");
        System.Console.WriteLine("Car 3 Color: " + car3.color);
        System.Console.WriteLine("Car3 Mileage" + car3.mileage);
        car3.color = "Gray";
        car3.mileage = 1100;
        System.Console.WriteLine("Car 2 Mileage: " + car2.mileage);
        System.Console.WriteLine("Car 3 Mileage: " + car3.mileage);
        car3.Drive(25);

        //System.Console.WriteLine("Car 1: " + car1.DisplayInfo());
        //System.Console.WriteLine("Car 2: " + car2.DisplayInfo());

        //with ToString override method
        System.Console.WriteLine("Car 1: " + car1.ToString());
        System.Console.WriteLine("Car 2: " + car2.ToString());



        Car car4 = new Car();
        Car car5 = new Car("Silver");
        Car car6 = new Car("Green", "Toyota", "Tacoma", 2020, 15000);
        Car car7 = new Car("", "Honda", "Accord", 0, 0);
        //System.Console.WriteLine(car4);
        //System.Console.WriteLine(car5);
        System.Console.WriteLine(car6);
        System.Console.WriteLine(car7);

        System.Console.WriteLine(car7.color.ToUpper());  // prints nothing since car7 above has no color in it
        System.Console.WriteLine(car7);


        // How to copy over one object's values to another object
        //No Arg
        Car car8 = new();
        car8.color = car6.color;
        car8.make = car6.make;
        car8.model = car6.model;
        car8.year = car6.year;
        car8.mileage = car6.mileage;

        //Full Arg way to do it
        Car car9 = new(car6.color, car6.make, car6.model, car6.year, car6.mileage);

        //Copy 
        Car car10 = new(car6);
        //Make a class ->  Name of file should match name of class (.cs)  ex Car.cs
    }
          //Tomorrow
        // Properties
        //Scopes (static keyword as well)
        //Access Modifiers

        //File Input/Output

        //Inheritance
        //Polymorphism 
}
