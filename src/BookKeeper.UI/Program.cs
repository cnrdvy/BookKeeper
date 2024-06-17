using BookKeeper.Application;
using BookKeeper.Infrastructure;
using BookKeeper.UI.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddApplication(BookKeeper.Application.AssemblyReference.Assembly);
builder.Services.AddInfrastructure(builder.Configuration);

WebApplication app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.ApplyMigrations();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

await app.RunAsync();

public partial class Program;
