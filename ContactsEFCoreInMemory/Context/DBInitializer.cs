using ContactsEFCoreInMemory.Context.Interfaces;

namespace ContactsEFCoreInMemory.Context;

public class DBInitializer
{
    public static void Initialize(ContactsContext context)
    {
        // Pre-Initialize Check if there is any contacts
        if (context.Contacts.Any()) return;

        var fake = new FakeDataService<Contact>();
        var data = fake.Collection(100);

        context.Contacts.AddRange(data);
    }
}
