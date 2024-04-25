

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Main method code here

        System.Console.WriteLine("This is my People Class and Object Assignment.");
       
        People person1 = new People();
    
        person1.name = "Cody";
        person1.homeState = "Virginia";
        person1.age = 26;
        person1.gender = "male";
        person1.hairColor = "brown";
        person1.favoriteActivity = "Racing";

        System.Console.WriteLine();

        System.Console.WriteLine(person1.name);
        System.Console.WriteLine(person1.homeState);
        System.Console.WriteLine(person1.age);
        System.Console.WriteLine(person1.gender);
        System.Console.WriteLine(person1.hairColor);
        System.Console.WriteLine(person1.favoriteActivity);
        person1.Race();

        System.Console.WriteLine();

        System.Console.WriteLine("My name is " + person1.name + ".");
        System.Console.WriteLine("I am from " + person1.homeState + ".");
        System.Console.WriteLine("I am " + person1.age + " years old");
        System.Console.WriteLine("I am a " + person1.gender + ".");
        System.Console.WriteLine("I have " + person1.hairColor + " hair");
        System.Console.WriteLine("My favorite activity is " + person1.favoriteActivity.ToLower() + ".");
        person1.Race();

        System.Console.WriteLine();

        System.Console.WriteLine(person1);

        System.Console.WriteLine();
        
        People person2 = new();

        person2.name = "Emily";
        person2.homeState = "Tennessee";
        person2.age = 29;
        person2.gender = "female";
        person2.hairColor = "brown";
        person2.favoriteActivity = "Singing";

        System.Console.WriteLine();

        System.Console.WriteLine(person2.name);
        System.Console.WriteLine(person2.homeState);
        System.Console.WriteLine(person2.age);
        System.Console.WriteLine(person2.gender);
        System.Console.WriteLine(person2.hairColor);
        System.Console.WriteLine(person2.favoriteActivity);
        person2.Sing();

        System.Console.WriteLine();

        System.Console.WriteLine("My name is " + person2.name + ".");
        System.Console.WriteLine("I am from " + person2.homeState + ".");
        System.Console.WriteLine("I am " + person2.age + " years old");
        System.Console.WriteLine("I am a " + person2.gender + ".");
        System.Console.WriteLine("I have " + person2.hairColor + " hair");
        System.Console.WriteLine("My favorite activity is " + person2.favoriteActivity.ToLower() + ".");
        person2.Sing();

        System.Console.WriteLine();

        System.Console.WriteLine();

        People person3 = new();

        person3.name = "Lenny";
        person3.homeState = "Pennsylvania";
        person3.age = 54;
        person3.gender = "male";
        person3.hairColor = "gray";
        person3.favoriteActivity = "Basketball";

        System.Console.WriteLine();

        System.Console.WriteLine(person3.name);
        System.Console.WriteLine(person3.homeState);
        System.Console.WriteLine(person3.age);
        System.Console.WriteLine(person3.gender);
        System.Console.WriteLine(person3.hairColor);
        System.Console.WriteLine(person3.favoriteActivity);
        person3.Basketball();

        System.Console.WriteLine();

        System.Console.WriteLine("My name is " + person3.name + ".");
        System.Console.WriteLine("I am from " + person3.homeState + ".");
        System.Console.WriteLine("I am " + person3.age + " years old");
        System.Console.WriteLine("I am a " + person3.gender + ".");
        System.Console.WriteLine("I have " + person3.hairColor + " hair");
        System.Console.WriteLine("My favorite activity is " + person3.favoriteActivity.ToLower() + ".");
        person3.Basketball();

        System.Console.WriteLine();

        People person4 = new();

        person4.name = "Sandy";
        person4.homeState = "Michigan";
        person4.age = 41;
        person4.gender = "female";
        person4.hairColor = "blonde";
        person4.favoriteActivity = "Eating";


        System.Console.WriteLine();

        System.Console.WriteLine(person4.name);
        System.Console.WriteLine(person4.homeState);
        System.Console.WriteLine(person4.age);
        System.Console.WriteLine(person4.gender);
        System.Console.WriteLine(person4.hairColor);
        System.Console.WriteLine(person4.favoriteActivity);
        person3.Eat();

        System.Console.WriteLine();

        System.Console.WriteLine("My name is " + person4.name + ".");
        System.Console.WriteLine("I am from " + person4.homeState + ".");
        System.Console.WriteLine("I am " + person4.age + " years old");
        System.Console.WriteLine("I am a " + person4.gender + ".");
        System.Console.WriteLine("I have " + person4.hairColor + " hair");
        System.Console.WriteLine("My favorite activity is " + person4.favoriteActivity.ToLower() + ".");
        person4.Eat();


         

             

      

        






    }
    
    private static void OpeningGreeting()
    {
        System.Console.WriteLine("Hello everyone.  We would like to get to know you better.");
        System.Console.WriteLine("Can you please introduce yourself?");
        System.Console.WriteLine("What is your name?");
    }
    
}
