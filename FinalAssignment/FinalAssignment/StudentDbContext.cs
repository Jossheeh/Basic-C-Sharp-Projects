public class StudentDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=StudentDb;Trusted_Connection=True;");
    }

    internal void SaveChanges()
    {
        throw new NotImplementedException();
    }
}
