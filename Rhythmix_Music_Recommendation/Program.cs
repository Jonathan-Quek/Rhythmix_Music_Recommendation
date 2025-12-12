using Rhythmix_Music_Recommendation.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rhythmix_Music_Recommendation.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<Rhythmix_Music_RecommendationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Rhythmix_Music_RecommendationContext") ?? throw new InvalidOperationException("Connection string 'Rhythmix_Music_RecommendationContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
