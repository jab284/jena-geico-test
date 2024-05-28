/*
Coding to interfaces - practice wherein we will start these "classes" that are functionality focused 
    (Repos, Services, Controllers)
    We will opt to Outline their Functionality through an Interface, first.

    The overall Goal is to promote Flexibility/Reusability.  
    If we ever need to change implementations, 
        you can simply create a new class that implements the SAME Interface thereby letting us know it will service all the same INTENTIONS.

*/


interface IUserRepo
{
    public abstract void AddUser(User u);
    public User? GetUser(int id);

    public List<User> GetAllUsers();
    public void UpdateUser(User u);
    public void DeleteUser(int id);
    public void Save();
    


    
}