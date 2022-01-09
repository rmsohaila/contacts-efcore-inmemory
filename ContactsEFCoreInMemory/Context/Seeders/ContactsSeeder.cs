namespace ContactsEFCoreInMemory.Context.Seeders;

public static class DatabaseContextSeed
{
    public static void Seed(this ModelBuilder builder, IFakeDataGenerator<Contact> fake)
    {
        var data = fake.Collection(2);

        builder.Entity<Contact>().HasData(data);
    }
}