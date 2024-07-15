using BookKeeper.Application.Users.RegisterUser;
using BookKeeper.Domain;
using BookKeeper.UI.Pages.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookKeeper.UI.Pages;

public sealed class RegisterModel(ISender sender) : PageModel
{
    [BindProperty]
    public UserViewModel UserModel { get; set; }

    public void OnGet(UserViewModel userModel) => UserModel = userModel;

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Result<Guid> result = await sender.Send(new RegisterUserCommand(
            UserModel.FirstName,
            UserModel.LastName,
            UserModel.Email));

        return result.IsSuccess
            ? RedirectToPage("/Index")
            : Page();
    }
}
