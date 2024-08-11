namespace BookKeeper.UI;

public static class PresentationModule
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddRazorPages();
        services.AddAutoMapper(BookKeeper.UI.AssemblyReference.Assembly);
        
        return services; 
    }
}
