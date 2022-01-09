using System.ComponentModel.DataAnnotations.Schema;

namespace ContactsEFCoreInMemory.Models;

public class Contact : IPrimaryKey
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
}

public interface IPrimaryKey
{
    int Id { get; set; }
}