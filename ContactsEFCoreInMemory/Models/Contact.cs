﻿namespace ContactsEFCoreInMemory.Models;

public class Contact
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
}