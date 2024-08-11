using BookKeeper.Application;
using BookKeeper.Infrastructure;
using BookKeeper.UI;
using BookKeeper.UI.Extensions;
using Serilog;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Host
    .UseSerilog(
        (context, loggerConfiguration) =>
            loggerConfiguration.ReadFrom.Configuration(context.Configuration));

builder.Services.AddPresentation();
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
