using ContactsEFCoreInMemory.Context.Seeders;

namespace ContactsEFCoreInMemory.Context;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly)
            .Seed(this.Database.GetService<IFakeDataGenerator<Contact>>());
    }

    public DbSet<Contact> Contacts { get; set; }
}
