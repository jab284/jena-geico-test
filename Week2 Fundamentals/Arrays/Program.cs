// See https://aka.ms/new-console-template for more information


//Arrays
/*
    Problem:  There is a lot of DATA that exists!!
    Managing each piece in its own variable is going to become impractical
    A lot is quite similar or related whether its by purpose or even Data type.

    We need to introduce a means to store multiple pieces of data within one device/var

    Arrays -> offers a way for us to very simply store multiple values of the same 

    We do NOT permanently store data in our application!

    Syntax:

    DataType[] variableName = new DataType[size];    // create an array of a certain size

    Arrays - in C# - have a fixed size upon instantiation (initialization)

    Arrays use Indexed (just like strings) -> An Array of size 5 - Indexed: 0-4
*/

//Basic example:
using System.Diagnostics.Contracts;

int[] numbers = new int[5];  //Not an int - its an array that holds an int - and holds 5 integers

    Console.WriteLine(numbers.Length);

//  -  new used when creating object in c# - tell application to a lot new memory allocation
// Assign a value to any "element" of this array
//numbers[0] = 10;
//numbers[3] //element of an array

numbers[0] = 10;
numbers[1] = 11;
numbers[2] = 12;

//Recall/Use said value stroed inside of any "element" of this array

Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[2]);

Console.WriteLine(numbers[4]);  // will assign 0 since it hasnt been declared

//Consle.WriteLine(number[10]); - IndexOutOfRangeException - acceptable
//Console.WriteLine(numbers[-1]); - Cannot use negative indices (in c#)

Console.WriteLine(numbers);  //System.Int32[]  error - 


//Foreach Loop

foreach(int num in numbers)
{
    Console.WriteLine(num);
}

//  string
string arrString = "{";
foreach (int num in numbers)
{
    arrString += "[";
}
arrString += "]";
Console.WriteLine(arrString);




//string arrString = "{";
foreach (int num in numbers)
{
    arrString += "[";
}
arrString = arrString.Substring(0, arrString.Length-1);
arrString += "]";
Console.WriteLine(arrString);
                  



//string arrString = "{";    //REMOVE Function
foreach (int num in numbers)
{
    arrString += "[";
}
arrString = arrString.Remove(arrString.Length-1);
arrString += "]";
Console.WriteLine(arrString);



//Join
string results = string.Join(", ", Array.ConvertAll(numbers, x=> x.ToString()));

string[] numberStrings = new string[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    numberStrings[i] = numbers[i].ToString();
}
Console.WriteLine(string.Join(",", numberStrings));  //these are arguments - ",", numberStrings



// SIMPLE
Console.WriteLine("-------");
foreach (int num in numbers)
{
    Console.WriteLine(num + " ");
    Console.Write(num + " ");
}


//Less Important

//Multi-dimensional Arrays

int[,] twoDimArray = new int[3,3];  // comma means 2 dimensional //
twoDimArray[0, 0] = 1;
twoDimArray[0, 1] = 2;


//Alternative syntax for instantiating Arrays
   //{} or [] represent arrays  separted by ,

string[] words = ["Hello", "Hi", "Hey"];  //ask ryan why o and 1
Console.WriteLine(words[0]);  //writing index 0 (first word)

// reassigning [1] index to Bye
words[1] = "Bye";
