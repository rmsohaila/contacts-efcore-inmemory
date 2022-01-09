namespace ContactsEFCoreInMemory.Context.Seeders;

public class DBSeeder
{
    public static void Initialize(DatabaseContext context)
    {
        if (context.Contacts.Any()) return;
        else
        {
            IFakeDataGenerator<Contact> contactData = new FakeDataService<Contact>();
            context.Contacts.AddRange(contactData.Collection(100));
        }

        context.SaveChanges();
    }
}
