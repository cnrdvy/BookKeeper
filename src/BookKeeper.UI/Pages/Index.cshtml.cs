using BookKeeper.Application.Books.GetBooks;
using BookKeeper.Domain;
using BookKeeper.UI.Pages.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace BookKeeper.UI.Pages;

public class IndexModel(ISender sender) : PageModel
{
    [BindProperty]
    public IReadOnlyCollection<BookViewModel> Books { get; set; }

    public async Task OnGetAsync()
    {
        Result<IReadOnlyCollection<BookResponse>> result = 
            await sender.Send(new GetBooksQuery());

        if (result.IsSuccess)
        {
            List<BookViewModel> books = [];
            
            books.AddRange(
                from BookResponse book in result.Value
                select new BookViewModel
                {
                    Id = book.Id,
                    Title = book.Title,
                    Description = book.Description,
                    Price = book.Price,
                    Authors = []
                });

            Books = books;
        }
    }
}
