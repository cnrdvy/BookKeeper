namespace BookKeeper.UI.Pages.Admin;

public sealed partial class CreateBookModel
{
    public sealed record BookViewModel(
        string Title, 
        string Description, 
        string Authors, 
        decimal Price);
}

