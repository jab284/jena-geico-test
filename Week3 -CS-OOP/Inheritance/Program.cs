using System;

class Program
{
    static void Main(string[] args)
    {
        // Main method code here
    Building b1 = new Building();  
    Building b2 = new Building(4, 1000);

        //Call both constructors
    System.Console.WriteLine(b1);  //No arg 
    System.Console.WriteLine(b2);   // full arg

    House h1 = new House();
    System.Console.WriteLine(h1);

    //What if I wanted to provide a number of walls and area to my house
    House h2 = new House(6, 500);
    System.Console.WriteLine(h2);

    //Full arg
    House h3 = new House(8, 750, 12, "Jen");
    System.Console.WriteLine(h3);
    
    }
}
