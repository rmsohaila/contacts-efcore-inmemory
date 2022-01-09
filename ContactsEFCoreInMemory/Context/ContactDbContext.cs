
namespace ContactsEFCoreInMemory.Context;

public class ContactsContext : DbContext
{
    public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder model)
    {
        base.OnModelCreating(model);
        var fake = this.Database.GetService<IFakeDataGenerator<Contact>>();
        var data = fake.Collection(100);
        model.Entity<Contact>().HasData(data);
    }

    public DbSet<Contact> Contacts { get; set; }
}
