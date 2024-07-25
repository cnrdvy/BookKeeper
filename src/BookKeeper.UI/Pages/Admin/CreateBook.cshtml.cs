using BookKeeper.Application.Books.CreateBook;
using BookKeeper.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookKeeper.UI.Pages.Admin;

public sealed partial class CreateBookModel(ISender sender) : PageModel
{
    [BindProperty]
    public BookViewModel BookModel { get; set; }

    public void OnGet(BookViewModel bookModel) => BookModel = bookModel;

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Result<Guid> result = await sender.Send(new CreateBookCommand(
            BookModel.Title,
            BookModel.Description,
            BookModel.Authors,
            BookModel.Price));

        return result.IsSuccess
            ? RedirectToPage("/Admin/Index")
            : Page();
    }
}
