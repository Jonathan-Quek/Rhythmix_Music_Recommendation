using Rhythmix_Music_Recommendation.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rhythmix_Music_Recommendation.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Rhythmix_Music_Recommendation.Components.Account;
using Rhythmix_Music_Recommendation.Services; // Simplified namespace

var builder = WebApplication.CreateBuilder(args);

// 1. Database Configuration
builder.Services.AddDbContextFactory<Rhythmix_Music_RecommendationContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Rhythmix_Music_RecommendationContext") ?? throw new InvalidOperationException("Connection string not found."));

    options.EnableSensitiveDataLogging();
}

    );


builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// 2. Razor Components and Interactivity
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient();

// 3. Authentication & Identity
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
    .AddIdentityCookies();

builder.Services.AddIdentityCore<Rhythmix_Music_RecommendationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<Rhythmix_Music_RecommendationContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

// 4. THE FIX: Private Music Data Service
// Changed from AddSingleton to AddScoped so every user has their own private list
builder.Services.AddScoped<MusicDataService>();

builder.Services.AddSingleton<IEmailSender<Rhythmix_Music_RecommendationUser>, IdentityNoOpEmailSender>();

var app = builder.Build();



// Configure the HTTP request pipeline.
// 5. Middleware Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints();



await DbInitializer.SeedSongsAsync(app.Services);

app.Run();
