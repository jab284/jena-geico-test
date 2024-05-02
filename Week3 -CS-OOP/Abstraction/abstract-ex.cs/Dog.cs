class Dog : Animal
{

    public string FavoriteChewToy { get; set; }

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