using System.Runtime.CompilerServices;

class People
{
    public string name;
    public string homeState;
    public int age;
    public string gender;
    public string eyeColor;
    public string hairColor;
    public string favoriteActivity;







    //No Arg Constructor
        //sets default
    public People()
    {
        favoriteActivity = "Sleeping";
    }

    //Full Arg Constructor
    public People(string name, string homeState, int age, string gender, string eyeColor, string hairColor, string favoriteActivity)
{
    this.name = name;
    this.homeState = homeState;
    this.age = age;
    this.gender = gender; 
    this.eyeColor = eyeColor;
    this.hairColor = hairColor;
    this.favoriteActivity = favoriteActivity;
    System.Console.WriteLine(this.name, this.homeState);
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
    /*
    public void Age();
    {
        totalAge = ()
    }
    */

}