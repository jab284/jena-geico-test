using Microsoft.EntityFrameworkCore;

class AppDbContext : DbContext
{
    

    public DbSet<User> Users { get; set; }
    public DbSet<Movie> Movies { get; set;}
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //read in out Connection String from out text file
        string connectString = File.ReadAllText(@"C:\Revature\DBConnections\MovieAppdbconnection.txt");
        optionsBuilder.UseSqlServer(connectString);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasOne(m => m.Renter).WithMany().HasForeignKey();
    }

}