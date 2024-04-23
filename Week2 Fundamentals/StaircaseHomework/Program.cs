// See https://aka.ms/new-console-template for more information

//Staircase Challenge
//Print 1 '*' for the 1st row.  Then 2 "*" for the 2nd row, etc
//int size;
//size = 4;

// The out loop deals with printing additional rows / steps / stairs
/*
//------------------------
//REGULAR ---- This one WORKS*/
/*
    *
    **
    ***
    ****
*/
/*
int size = 4;
for (int i = 1; i <= size; i++)
{
        // the inner loops deals with printing the contents of each row / steps / stairs
    for(int j = 1; j <=i; j++)
    {
        Console.Write("* ");
    }
        Console.WriteLine("");
}
*/



//-----------------------------------
// Staircase challenge Continued

// There are 3 other directions that the staircase can "face"
//Build them all



//--------------------------------------
/*
Inverted --  THIS ONE WORKS!!!
****
***
**
*
*/
/*
int size = 4;


for (int i = 1; i <= size; i++)
{
        // the inner loops deals with printing the contents of each row / steps / stairs
    for(int j = 4; j >=i; j--)
    {
        Console.Write(" *");
    }
        Console.WriteLine("");
}
*/
     //OR
/*
int size = 4;

//for (int i = 1; i <= size; i++)
for (int i = 0; i <= size; i++)
{          
    for(int k =size; k > i; k--)
    {
       Console.Write("* ");
    }
        Console.WriteLine("");
}
*/

//-----------------------------------------------

/*
Right-facing      THIS WORKS EM
   *
  **
 ***
****
*/
/*
int size = 4;

for (int i = 1; i <= size; i++)
{
    for (int p = size; p > i; p--)
    {
        Console.Write("  ");
    }
    for (int p = 0; p < i; p++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("");
}
*/

//-----------------------------------------------
/*
Inverted Right facing    ----THIS WORKS EM
****
 ***
  **
   *

*/

/*

int size = 4;

for (int i = size; i >= 0; i--)
{
    for (int k= size; k > i; k--)
    {
        Console.Write("  ");
    }
    for (int k = 0; k < i; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("");
}

*/

//- Afterwards: Solve any of them with a single loop



//All Together Works EM
///*
int size = 4;

for (int i = 1; i <= size; i++)
{
    for (int k = 1; k <= i; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("");
}

Console.WriteLine();




for (int i = 1; i <= size; i++)
{
    for (int k = size; k > i; k--)
    {
        Console.Write("  ");
    }
    for (int k = 0; k < i; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("");
}

Console.WriteLine();




for (int i = size; i >= 0; i--)
{
    for (int k = 1; k <= i;  k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("");
}

Console.WriteLine();




for (int i = size; i >= 0; i--)
{
    for (int k = size; k > i; k--)
    {
        Console.Write("  ");
    }
    for (int k = 0; k < i; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("");
}


