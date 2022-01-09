namespace ContactsEFCoreInMemory.Context;

public class DBInitializer
{
    public static void Initialize(ContactsContext context)
    {
        // Pre-Initialize Check if there is any contacts
        if (context.Contacts.Any()) return;


    }
}
