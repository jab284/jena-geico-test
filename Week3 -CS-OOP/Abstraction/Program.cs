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
        
        d.Value = 100;

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


        Animal[] animals = new Animal[4];  //not creating an animal object / creates an array of animals
                        //cant create new animal is is abstract class

        animals[0] = d;
        animals[1] = c;
        animals[2] = bugs;

        ICarnivore[] carnivores = new ICarnivore[3];

        carnivores[0] = d;
        carnivores[1] = c;

        IAdorables[] adorables = new IAdorables[3];

        adorables[0] = bugs;
        adorables[1] = c;

        TeddyBear bear = new();

        adorables[2] = bear;




    }

    




}
