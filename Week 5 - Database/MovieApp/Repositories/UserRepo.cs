class UserRepo
{


   UserStorage userStorage = new(); 

   //Add, get-one, get-all, update and delete

    public User AddUser(User u)
    {
        u.Id = userStorage.idCounter++;
        userStorage.users.Add(u.Id, u);
        return u;
    }

    public User? GetUser(int id)
    {
        if (userStorage.users.ContainsKey(id))
        {
            User selectedUser = userStorage.users[id];
            return selectedUser;
        }
        else 
        {
            System.Console.WriteLine("Sorry no user exists with that DI.  Please try again.");
            return null;
        }
    
    }

    public List<User> GetAllUsers()
    {
        return userStorage.users.Values.ToList();
    }

    public User? UpdateUser(User updatedUser)
    {
         try
        {
            userStorage.users[updatedUser.Id] = updatedUser;
            //I choose to send the updated movie back as a "response-feedback" system.
            //"Here is me telling you that I have updated the storage with this movie I send back to you"
            return updatedUser;
        }
        catch (Exception)
        {
            System.Console.WriteLine("Invalid Movie ID - Please Try Again");
            return null;
        }
    }

    public User? DeleteUser(User u)
    {
         bool didRemove = userStorage.users.Remove(u.Id);

        if (didRemove)
        {
            //now we will return the movie that got deleted.
            return u;
        }
        else
        {
            System.Console.WriteLine("Invalid Movie ID - Please Try Again");
            return null;
        }
    }

}