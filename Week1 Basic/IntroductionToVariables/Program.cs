// See https://aka.ms/new-console-template for more information

//This is main command to print
using System.IO.Compression;

Console.WriteLine("Hello, World!");  //Bonus: String Literal

//Variables - designed to hold data/information within application for additional later use

//Variable Declaration - tell application to create this variable in memory

//Syntax: DataType - nameOfVariable;

//Data Types - indicates what kind of info allowed to be stored within that variable
//"Primitive" Data Types - Admittedly C# refers to Primitive as "Structs"
//      - Serve ONE purpose.  Holding a single value
//      - In C# we call these value-types (vs reference-types)
//      - hold on to value and want it to do something or reference a value of action (drive my car is reference)
//      - Numerical value-types: (sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal)   
//           INT is most important and one we will use - will default to INT
//      - Non-numerical value-types (char, bool, enum, struct)

// 12345 default to particular data type which is int
// 1 - Number Literal - physically typing some number into your code
//100000000.1 
//Int, Double, Sometime Long  (used most often)

//Non numerical

//variable should not start with number


int numberOfDogs;   // variables should be camelCase - "number" is the name of variable - Yellow is warning

// Variable assignment
// Syntax: variableName = some-value;
numberOfDogs = 10;
numberOfDogs = 5;     //Re-assignment

Console.WriteLine(numberOfDogs);
//Console.WriteLine(10);


//Variable Declaration and Assignment
double amount = 12.50;       //default for decimal   allocate 64 bits in memory for "money" and assign variable
System.Console.WriteLine(amount);    // shortcut of cw Enter - adds word system

// = -> Assignment Operator   ex "set" amount to 12.5

// Basic Operations:
int num = 1 + 2;   //data type "int" / variable is "num" / value is 1+2
num = 1 - 2;  // subtraction
num = 1 * 3;  // multiplication
num = 1 / 3;  // division      whole number divided by whole number with NO decimal - keeps INT - Integer Division - 
              //answer is 0 as 3 doesn't go into 1
              //Integer doesnt store decimal
 //num = 1 / 3.0;  // will still return as 0 - as it turns back to INT which doe not do decimal - truncates: and does not round up  
            // will give error 

double num2 = 1 / 3.0;  // will give 0.333333333

Console.WriteLine(num2);
Console.WriteLine(1 / 3.0);
Console.WriteLine(0.1 + 0.2);     //  C# thinks in binary - does not add the 2 numbers

//num = 1 % 3;  //Modulus  - what is remainder of 1 divided by 3 -= remainder of 2



//Augmented (Compound) Assignment Operators

// If I want to perform a calculation on a variable AND store that results back into the variable


int num3 = 10;
//int result = num3 * 3;
num3 = num3 * 3;   // take num3 (10) and multiply by 3 (30) and reassign back into num3 - 10 * 3 and puts 30 back into num3
num3 = num3 * 3;    // compounded to previous new num3 (30 * 3 and puts 90 back in num3)
// int result = num3 * 3;
Console.WriteLine(num3);

// OR
Console.WriteLine(num3);        //Prints num3 (10)
Console.WriteLine(num3 + 5);    //prints num3 (10) plus 5 - and puts 15 back into num3
num3 = num3 + 5;
Console.WriteLine(num3);        //prints new num3 (15)


// Augmented Assignment Operator    come back to!!!
num3 += 5;      // exactly same as num = num3 + 5;
num3 -= 10;     // exactly same as num = num3 - 10
num3 *= 2;      // exactly same as num = num3 * 2;
num3 /= 2;      // exactly same as num = num3 / 2;
num3 %= 2;      // exactly same as num = num3 % 2;  remainder only
Console.WriteLine(num3);

//Increment / Decrement Operators
num3++;     // Increment - Add exactly 1  -> num3 +=1    ->  num3 = num3 +1;
num3--;     // Decrement - Subtract exactly 1   -> num3 -=1     -> num3 = num3 - 1;

++num3;
--num3;

Console.WriteLine(num3);

Console.WriteLine(num3++); //Post Increment Operator  (after number and wil increment after used in context)  Placement of + sign is after
Console.WriteLine(num3);
Console.WriteLine(++num3);  // Pre Increment Operator    Placement of + sign  ++ is before


// Booleans - value type that stores with 'true' OR 'false"

bool isSunny = true;
bool isRainy = false;

Console.WriteLine(isSunny);


// ! -> Null Operator - Negation Operator - change boolean to its opposite value
Console.WriteLine(!isSunny);  // opposite value because of !

isSunny = !isSunny; // A toggle -> switch isSunny's value to the other boolean  / permanently changes isSunny variable
Console.WriteLine(isSunny);


//Relational Operators - compare one value to another value - Binary Operators
// ==  measure equality , != means not equal, <, >, <=, >=

Console.WriteLine(5==5);  // Boolean expression -> expression that evaluates to true or false
Console.WriteLine(numberOfDogs == 5);  // use of variable with expression
Console.WriteLine(numberOfDogs != 5);  // variable expression with !
Console.WriteLine(numberOfDogs > 5);    // variable expression with >
Console.WriteLine(numberOfDogs < 7);    // variable expression with <
Console.WriteLine(numberOfDogs <= 7);   // variable expression with <=
Console.WriteLine(numberOfDogs >= 7);   // variable expression with >=


//Get ahead Study tip - Logical Operators - Conditional Statements - Loops

//Other Topics - Strings, Concatenations, Maybe Lists





