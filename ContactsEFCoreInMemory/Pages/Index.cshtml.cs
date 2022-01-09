namespace ContactsEFCoreInMemory.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly DatabaseContext context;

    public Contact Contact { get; set; }
    public IList<Contact> Contacts { get; set; }

    public IndexModel(ILogger<IndexModel> logger, DatabaseContext context)
    {
        _logger = logger;
        this.context = context;
    }

    public void OnGet()
    {
        this.Contacts = context.Contacts.ToList();
    }
}
