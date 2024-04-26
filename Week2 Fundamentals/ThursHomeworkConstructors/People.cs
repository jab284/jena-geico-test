using System.Runtime.CompilerServices;

class People
{
    public string name;
    public string homeState;
    public int age;
    public string gender;
    public string hairColor;
    public string favoriteActivity;







    //No Arg Constructor
        //sets default
    public People()
    {
        favoriteActivity = "Sleeping";
    }

    //Full Arg Constructor
    public People(string name, string homeState, int age, string gender, string hairColor, string favoriteActivity)
    {
        this.name = name;
        this.homeState = homeState;
        this.age = age;
        this.gender = gender; 
        this.hairColor = hairColor;
        this.favoriteActivity = favoriteActivity;
    
    }


    //ToString
    public override string ToString()
    {
        string str = "";
        str += "{Name: " + name;
        str += "; Home State: " + homeState;
        str += "; Age: " + age;
        str += "; Gender: " + gender;
        str += "; Hair Color: " + hairColor;
        str += "; Favorite Activity: " + favoriteActivity;
        return str;
        
    }



    //Method1

    public void Eat()
    {
        System.Console.WriteLine("Chomp Chomp!");
    }

 
    public void Basketball()
    {
        System.Console.WriteLine("Swishhhh!");
    }

    public void Race()
    {
        System.Console.WriteLine("Vroom Vroom!");
    }


    public void Sing()
    {
        System.Console.WriteLine("La La La La");
    }
    
    public static int AddAges(People person1, People person2, People person3, People person4)
    {
        return person1.age + person2.age + person3.age + person4.age;
    }
    

}