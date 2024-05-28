using Microsoft.EntityFrameworkCore;

class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Read in our Connection String from our txt file
        string connectionString = File.ReadAllText(@"C:\Users\RyanSchlientz\Documents\TrainingBatches\2404-geico-dotnet\Week6-Frameworks\movie-app-db.txt");
        optionsBuilder.UseSqlServer(connectionString);
    }
}