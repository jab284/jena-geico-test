namespace Abstraction;

class Dog : Animal, ICarnivore
{

    public string FavoriteChewToy { get; set; }
    public int Value {get; set; }

    public Dog()
    {
        FavoriteChewToy = "";
    }
    public override void MakeSound()
    {
        System.Console.WriteLine("Bark Bark");
    }

    public void EatMeat()
    {
        System.Console.WriteLine("Eats dog food");
    }

}