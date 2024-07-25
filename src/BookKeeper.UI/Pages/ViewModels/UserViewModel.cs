using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BookKeeper.Domain.ValueObjects;

namespace BookKeeper.UI.Pages.ViewModels;

public sealed record UserViewModel
{
    [DisplayName("First Name")]
    public string FirstName { get; set; }

    [DisplayName("Last Name")]
    public string LastName { get; set; }

    [DisplayName("Email Address")]
    [EmailAddress]
    public string Email { get; set; }

    [PasswordPropertyText]
    public string Password { get; set; }

    [DisplayName("Password Confirmation")]
    [PasswordPropertyText]
    public string PasswordConfirmation { get; set; }
}
