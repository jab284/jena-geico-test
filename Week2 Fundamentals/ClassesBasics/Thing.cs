class Thing
{
    //Scope  
    /*
        Scope - a way to measure a range of visibility/ existence of a particular entity.
          
    
        Object Scope - 
            * Exists within any object of this class 
            * Each object gets its own copy of this variable with its own value
        */
    public int objectNum;

    // Class Scope - belongs to the entire Class, and by extension, each Object of that Class
        // The value of Class Scoped variables remains the same between each Object (Shared)
        // To put in Class Scope - You must be in the areas

    public static int classNum = 10;  // use static keyword - transformed this into   every object will have classNum 10
    public static int count = 0;
    //Single Constructor
    public Thing()
    {
        objectNum = 100;
        count++;
    }

    // A Static Method
    public static void StaticMethod()
    {
        //Static methods cannot use non-static members (fields and methods)
        System.Console.WriteLine(count);
        System.Console.WriteLine(classNum);
        //System.Console.WriteLine((objectNum));
        //SomeMethod();

        System.Console.WriteLine("This is a static method from the Thing Class!");
    }

    /*
    Method Scope
        * Any variable we create (declare) inside of a method 
        * OR any parameter used by that method is "scoped" to that Method.
        * Will no longer be used after the Method is finished
    */
    public void SomeMethod(int paramNum)
    {
        int methodNum = 10;

        //Parameters and variables created within a Method can be used so long as we are still in that method
        System.Console.WriteLine(paramNum);
        System.Console.WriteLine(methodNum);

        //Can still access the Object/Class Scoped variables
        System.Console.WriteLine(objectNum);
        System.Console.WriteLine(classNum);


        /*Block Scope 
            * Any variable created within a *block* of code can only be used within that context
            * A *block* -> Conditionals / Loops / etc...
        */

        if (true)
        {
            int blockNum = 100;
            System.Console.WriteLine(blockNum);
        }
        else
        {
            //Cannot use the block scoped variable above since we have left the block of code.
            //System.Console.WriteLine(blockNum);
        }


        for(int i = 1; i <= 100; i++)
        {
            System.Console.WriteLine(i);
        }
        //Cannot use the block scoped variable above "i" since we have left that block of code.
        //System.Console.WriteLine(i);
    }

}