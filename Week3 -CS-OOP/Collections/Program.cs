using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        //Data Structure -> Arrays
        int[] numbers = new int[5];
        string[] words = new string[5];
        
        //Collections

                //Lists -> stores all of its values inside an array
            
                //Parameterized Class ...
                    //Generics - Generic Classes
                    //DataType<elementType> //the syntax is =  variableName = new DataType<elementType>();

        List<int> nums = new List<int>();
        //List<int> nums = [];  //Reduced or shorthand syntax

        //Add values
        nums.Add(10);
        nums.Add(20);
        nums.Add(30);


        //Printing out items in a Collection

            //Long way
            foreach(int num in nums)
            {
                System.Console.WriteLine(num);
            }

            //One Liner
            System.Console.WriteLine(string.Join(", ", nums));


    //----------------------

        //Insert a value somewhere other than at the end
        nums.Insert(0, 40);  // first number indicates the index where you want to enter.. and second number is the item or num to insert
         System.Console.WriteLine(string.Join(", ", nums));

         //Add/Insert multiple values
         //Another list
         List<int> nums2 = [1, 2, 3];
         nums.AddRange(nums2);
         nums.InsertRange(0,[4, 5, 6]);
         System.Console.WriteLine(string.Join(", ", nums));

        //IndexOf
        System.Console.WriteLine(nums.IndexOf(30)); //it returns the slot that '30' is in

        System.Console.WriteLine(nums.Contains(25));  //true false - is it in the list or not in the list

        //Accessing an Element
        System.Console.WriteLine(nums[0]);  //what is in the index asked for

        //Remove Element
        nums.Remove(20);    //Remove '20 from the list
        nums.RemoveAt(0);   //Remove the 0-indexed element - the very first one in example
        System.Console.WriteLine(string.Join(", ", nums));

        //Reverse
        nums.Reverse();
       System.Console.WriteLine(string.Join(", ", nums));

        //Sort
        nums.Sort();
        System.Console.WriteLine(string.Join(", ", nums));

    //Self Study : IComparable,datatype> -> see how you can add it to your own classes - thus allowing them to be sorted.


    //Lists();
    StacksAndQueues();

    //Hashsets
     HashSets();

     //Dictionary
     Dictionaries();

  

    }




    //Stacks and Queues
    private static void StacksAndQueues()
    {
        //There are more collections than just Lists.
        //Stacks and Queues take a slightly different strategy to data storage.
        //They see it as a holding cell where data enters in a particular order.
        //And then exits (removed from collection) in a a particular order.

        //Stacks have a strategy -> First In, Last Out -> FILO
        //Queues have a strategy -> First in, First Out -> FIFO

        Queue<int> queue = new();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        System.Console.WriteLine("First removed item: " + queue.Dequeue());
        queue.Enqueue(4);

        while (queue.Count > 0)
        {
            System.Console.WriteLine("Dequeued: " + queue.Dequeue());
        }

        Stack<int> stack = new();

        stack.Push(10); 
        stack.Push(20); 
        stack.Push(30); 

        System.Console.WriteLine("First popped item: " + stack.Pop());  //removed most recent item added
        stack.Push(40);

        while (stack.Count > 0)
        {
             System.Console.WriteLine("Popped: " + stack.Pop());
        }
    }

      

       // HashCode Sets
    private static void HashSets()
        {
            //Hash - a way of storing values - usually using some of the items data to help formulate a spot for the hash to store said item
            
            //Set - do not preserve any order insertion -> duplicates are NOT allowed

            HashSet<double> set = [1, 2, 3, 4, 1];

            set.Add(5);
            set.Add(5); //ignores duplicates

             System.Console.WriteLine(set.Contains(4));
        // foreach (double num in set)
        // {
        //     System.Console.WriteLine(num);
        // }
        System.Console.WriteLine(string.Join(",", set));

        HashSet<double> set2 = [2, 3, 4, 7, 10];
        System.Console.WriteLine(string.Join(",", set2));

        set.IntersectWith(set2);
        System.Console.WriteLine(string.Join(",", set));

        }

        //Dictionaries

        private static void Dictionaries()
        {
            //Dictionaries - store Key-Value Pairs
                //* myst pick one of TWO data types.  One represents the Key, the other:
                //Real world equivalences - Dictionary, SSN -> Person 

            Dictionary<string, int> studentScores = new();
            studentScores.Add("Kirk", 75);
            studentScores.Add("Carol", 90);
            studentScores.Add("Kevin", 80);

            //Accessing elements in the dictionary
            System.Console.WriteLine("Kirk's score " + studentScores["Kirk"]);

            studentScores["Kirk"] = 78;
            System.Console.WriteLine("Kirk's Score: " + studentScores["Kirk"]);

            System.Console.WriteLine(studentScores.ContainsKey("Kirk"));
            
            System.Console.WriteLine("Bob's Score: " + studentScores["Bob"]);

           /* foreach (KeyValuePair<string, int> kpv in)
            {
                System.Console.WriteLine(kpv.Key + ": " + kpv.Value);
            }
            */

           

             foreach (var kvp in studentScores)
            {
            System.Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }

        }


   
}