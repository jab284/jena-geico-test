using System.Linq;

class Program
{
    static IUserRepo ur;

    static void Main(string[] args)
    {
        //Test out LINQ and Lambda Expressions
        // LambdaTest();
        using AppDbContext context = new();
        ur = new UserRepo(context);

        //Create a new User
        // User newUser = new(0, "brian", "pass3", "user");
        // ur.AddUser(newUser);
        // ur.Save();
        // System.Console.WriteLine("User added successfully");

        TestGetUpdateDelete();

    }

    private static void TestGetUpdateDelete()
    {
        //Get User By Id
        User? u = ur.GetUser(1);
        if (u != null)
        {
            System.Console.WriteLine(u);
        }
        else
        {
            System.Console.WriteLine("User not found!");
        }

        //Update User
        u.Password = "pass123";
        ur.UpdateUser(u);
        ur.Save();
        //Easy to see if changes happened:
        System.Console.WriteLine(ur.GetUser(1));


        //Delete User
        ur.DeleteUser(1);
        ur.Save();

        //Check that user 1 isnt in All Users?
        List<User> allUsers = ur.GetAllUsers();
        List<User> allUsersWithId1 = allUsers.Where(user => user.Id == 1).ToList();
        System.Console.WriteLine(allUsersWithId1.Count == 0);
    }

    public static void LambdaTest()
    {
        List<int> numbers = [9, 10, 1, 2, 3, 4, 5, 6, 7, 8];
        List<string> words = ["Hello", "Hey", "Hi", "Goodbye"];

        List<int> evenNumbers = numbers.Where(num => num % 2 == 0).ToList();
        var hWords = words.Where(word => word.Substring(0, 1) == "H");

        evenNumbers.ForEach(num => System.Console.WriteLine(num));

        evenNumbers = evenNumbers.OrderBy(x => x).ToList();
        System.Console.WriteLine("==============");
        evenNumbers.ForEach(num => System.Console.WriteLine(num));

    }
}