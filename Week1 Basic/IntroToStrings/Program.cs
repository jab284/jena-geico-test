// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

//Strings - sequence of characters (letters, numbers, symbols, and whitespace)
//      - represented with "double quotes" in C# for the String Literals
//      - "HelloWorld!" is a String Literal
//      - The type here is a String
//      - String is a reference-type (aka and Object data type)
//          * Objects have more capabilities than just storing a value
//          * They can also have methods to perform various functionality (potential)
//          * Example Car Object:
//                  - States - Fields - properties (variables - pieces of data - about said object)
//                          * Color
//                          * Make
//                          * Model
//                          * Year
//                          * Vin
//                          * numberOfTires
//                          * Horsepower
//                          * numberOfDoors
//                          * Mileage
//                  - Behaviors - Methods - functionality we wish to perform with our object
//                          * Driver
//                          * Park
//                          * TurnOnRadio
//                          * RollDownWindows
//                          * Reverse
//                          * TurnOnWipers
//                          * BlowHorn
//                          * TurnOnHeadLights
//                          * TurnOnTurnSignal

// Create a string variable
string word = "Hello";

Console.WriteLine(word);

// To access fields and methods from objects we create we use the "." (member access) operator - referred to as dot operator

Console.WriteLine(word.Length);
Console.WriteLine(word.Length + 2);

word = "Hola";

Console.WriteLine(word.Length);  //field or property
Console.WriteLine(word.ToUpper());  //function - must be () - changes to Upper Case
Console.WriteLine(word.ToLower());  //function - must be () - changes to Lower Case



// ToUpper();
// WriteLine(word); //Argument - what do you want to have printed
// When defining a Method: referred to as the method's parameters
        // Parameter - Required info needed
        


word = "Hello World!";

Console.WriteLine(word.Length);
Console.WriteLine(word.Substring(3));  /*allows portion of string  ex just Hello / 
                                      substring starts at a specified character position and continues to the end of the string
                                    */

Console.WriteLine(word.Substring(0));


        /* Indexes - Strings and other carious collection-based devised use Indexes/Indexing

            Indexes describe the position of that element with the entire set of data.
            Strings -> the position of the character within the entire string.

            Indexes (in MOST programming languages) are 0-indexed.
            The 1st character in the String starts at the index 0.
                - The 2nd character is at the index 1, etc
                - The Last Index of any String is: Length -1 */

word = "need a break";

Console.WriteLine(word.Substring(0));       //start at index
Console.WriteLine(word.Substring(4,6));   //1st # is start at index and 2nd # gives the total # of characters from the start "total of 6 char"  
Console.WriteLine(word.Substring(3,7));

//stack trace - every time your application runs and calls methods it is stacked


//String Concatenation
    //when using the +" sign with Strings the behavior changes awa from (mathematical) addition.
    //Concatenation - the combining of 2 or more strings that we conjoin all the characters into one new string.

string phrase = "Hello " + "World";
Console.WriteLine(phrase);

string fname = "Jen";
string lname = "Arnold";
Console.WriteLine("Hello, my name is " + fname + " " + lname + "!");

int num1 = 1;
int num2 = 2;

Console.WriteLine("Num1 - " + num1);
Console.WriteLine("Num2 = " + num2);

Console.WriteLine("1" + 1);  //performs concatenation, NOT addition



//value-type -> == measures if they have the same value
num2 = 1;
Console.WriteLine(num1 == num2);


//reference-types -Objects -> == this will check if they are the SAME Object in Memory
Object obj1 = new ();    // when object created it sets aside memory
Object obj2 = new ();     // new object creates new set of memory

Console.WriteLine(obj1 == obj2);   //False - 2 different places in memory

Console.WriteLine(obj1.Equals(obj2));  

string word1 = "Hello";  //strings created with same name stay in same place in memory
string word2 = "Hello";  //strings created with same name point to same place in memory
Console.WriteLine(word1 == word2);  //True - 
    //Strings utilize what is called String Pool
    //Strings that are assigned the same value will point the same location in memory
    //This is done to conserve on memory for strings.
    //Strings are immutable - memory cannot be changed

    //Garbage collected - goes through memory we have - if not needed anymore - gets cleaned up in memory


//Int object does not change memory place when object changes
    //* num1 = 123456  - change - num1 = 12468 -> stays in same memory spot
//String of all same name uses the SAME memory spot - if object changed the new object will create new memory spot
    //ex word1 = "Hello";   word2 = "Hello";    change word2 = "Hey"; - Hey changes to new memory storage

word2 = "Hey";
Console.WriteLine(word2);
Console.WriteLine(word.Length);


