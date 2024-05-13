class UserService
{
    
    UserRepo ur = new();


    //Register
    public User? RegisterUser(User u)
    {

        //do not let them register if the role is anything other than "user"
        if(u.Role != "user")
        {
            //reject them
            System.Console.WriteLine("Invalid Role - Please try again!");
            return null;

        }

        //do not let them register if the name is already taken! :o
        //Get all users
        List<User> allUsers = ur.GetAllUsers();
        //Check if our new username matches any of the usernames on all those users.
        foreach(User user in allUsers)
        {
            if(user.Username == u.Username)
            {
                System.Console.WriteLine("User already taken! Please try again!");
                return null; //reject them
            }
        }
        //IF we make it this far, then we are saying the role is good to go.
        //and the username is good to go.
        return ur.AddUser(u);

   
    }


    //Login
    public User? LoginUser(string username, string password)
    {
        //Get all users
        List<User> allUsers = ur.GetAllUsers();
        //check each ont to see if we find a match
        foreach(User user in allUsers)
        {
            if(user.Username == username && user.Password == password)
            {
                //Yay Login
                return user; //us returning the user will indicate success
            }
        }

        //If we make it this far - we didnt find a match! Oh no!
        System.Console.WriteLine("Invalid Username / Password combo! PLease try again!");
        return null; //Reject the login
        //If so they login -> return user
        //otherwise, reject the login -> return null
    }

}