class Cat : Animal, ICarnivore
{
    
    public int Value {get; set; }
    public override void Sleep()
    {
        System.Console.WriteLine("Curls up.");
    }

    public override void MakeSound()
    {
        System.Console.WriteLine("Meow Meow");
    }

    public void EatMeat()
    {
        System.Console.WriteLine("Eats cat food");
    }
}