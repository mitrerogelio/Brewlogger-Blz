using System.ComponentModel.DataAnnotations;

namespace Brewlogger_Blz.Models;

public class Account
{
    public int UserId { get; }
    [Required] public string FirstName { get; set; }
    [Required] public string LastName { get; set; }
    [EmailAddress] public string Email { get; set; }
    public bool Active { get; }
}