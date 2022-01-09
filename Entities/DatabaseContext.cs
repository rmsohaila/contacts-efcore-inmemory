using Microsoft.EntityFrameworkCore;

namespace Entities;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //builder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly)
        //    .Seed(this.Database.GetService<IFakeDataGenerator<Contact>>());

        base.OnModelCreating(builder);
    }

    public DbSet<Contact> Contacts { get; set; }
}
