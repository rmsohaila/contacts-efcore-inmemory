﻿using System.ComponentModel.DataAnnotations;

namespace Entities;

public class Contact
{
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
