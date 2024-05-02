namespace Abstraction;

class Program
{
    static void Main(string[] args)
    {
        // Main method code here
        Dog d = new();
        d.Sleep();
        d.MakeSound();
        d.Species = "Border Collie";
        d.FavoriteChewToy = "Bone"; //Specific to Dogs
        d.EatMeat();

        System.Console.WriteLine();

        System.Console.WriteLine("------------------");

        Cat c = new();
        c.MakeSound();
        c.Species = "Calico";
        c.EatMeat();

        c.Value = 101;

        System.Console.WriteLine(c.Value);
        

        System.Console.WriteLine("----------------");

        Bunny bugs = new();
        bugs.MakeSound();
        bugs.Sleep();
        //bugs.EatPlant();

        IHerbivore b = new Bunny();
        //Seems to be the only way to use concrete interface method run
        b.EatPlant();


    }

    




}
