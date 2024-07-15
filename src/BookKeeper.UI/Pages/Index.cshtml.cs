using BookKeeper.Application.Books.GetBooks;
using BookKeeper.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookKeeper.UI.Pages;

public class IndexModel(ISender sender) : PageModel
{
    [BindProperty]
    public IReadOnlyCollection<BookResponse> Books { get; set; }

    public async Task OnGetAsync()
    {
        Result<IReadOnlyCollection<BookResponse>> result = 
            await sender.Send(new GetBooksQuery());

        if (result.IsSuccess)
        {
            Books = result.Value;
        }
    }
}
