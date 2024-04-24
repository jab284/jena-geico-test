// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
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




        //Make a class ->  Name of file should match name of class (.cs)  ex Car.cs

        //Tomorrow
        // ToString method
        //Copying Object references
        // Properties
        //Constructors
        //Scopes (static keyword as well)
        //Access Modifiers

        //Inheritance
        //Polymorphism 




    }
}
