using System.ComponentModel.DataAnnotations;
using BookKeeper.Domain.Entities;

namespace BookKeeper.UI.Pages.Admin;

public sealed record BookViewModel
{
    public Guid Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public IEnumerable<Author> Authors { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = ValidationErrorMessages.NumberMustBeGreaterThanZero)]
    public decimal Price { get; set; }

    internal static class ValidationErrorMessages
    {
        public const string NumberMustBeGreaterThanZero = "The Price field must be greater than 0.";
    }
}
