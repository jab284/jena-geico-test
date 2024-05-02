namespace Abstraction;

abstract class Animal
{
   

/*
Abstract Class - 
    * Two type sof Methods you can make in Abstract Classes:
        * Concrete Methods - The methods have an Implementation.
        * Abstract Method - These methods will not have an implementation
            - and any class (that is not also abstract) will have to provide said implementation
*/

    public string Species { get; set;}

    public Animal()
    {
        Species = "";
    }


    //Concrete method - does something
    public virtual void Sleep()
    {
        System.Console.WriteLine("Animal rests to recover energy.");
    }

    //Abstract method - not telling you how to make sound - just that you will make sound
    public abstract void MakeSound();  
    



}

