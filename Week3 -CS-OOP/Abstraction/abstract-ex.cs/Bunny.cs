namespace Abstraction;

class Bunny : Animal, IHerbivore
{
    public override void MakeSound()
    {
        System.Console.WriteLine("What's up doc");
    }
    
}