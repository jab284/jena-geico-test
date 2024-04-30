using System;

class Program
{
    static void Main(string[] args)
    {
        // Main method code here

        
        string filepath = "example.txt";
        //create device to write to file
        /*
        //StreamWriter writer = new StreamWriter(filepath); // overrides what is there in file
        StreamWriter writer = new StreamWriter(filepath, true);  // allows to append--make changes

        writer.WriteLine("Hello");
        writer.WriteLine("This writes to the text file.");  //This writes to the actual file
        writer.WriteLine("Ensure it writes this in text file");

        System.Console.WriteLine("This is for writing out on console app.");

        writer.Close();  //Ends and closes object / Finishes before executing the Close

        //Streamwriter overrides info by default - if doesn't exist - creates text file
        */

        //Using block - can close on its own with using statement
        //WriteToFile(filepath);
        ReadFromFile(filepath);
        
    }

    private static void WriteToFile(string filepath)
    {
        using (StreamWriter writer = new StreamWriter(filepath, true))
        {
            writer.WriteLine("Hello");
            writer.WriteLine("This writes to the text file.");  //This writes to the actual file
            writer.WriteLine("Ensure it writes this in text file");
            writer.WriteLine("Ensure it writes this in text file");

            System.Console.WriteLine("This is for writing out on console app.");
        }
    }


     private static void ReadFromFile(string filepath)
    {
        using (StreamReader reader = new StreamReader(filepath))
        {
           string line;
           line = reader.ReadLine();
           while(line != null)
           {
                System.Console.WriteLine(line);
                line = reader.ReadLine();
           }
        
        }
    }

    
}
