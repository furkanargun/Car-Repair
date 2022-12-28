using CarRepair.Data;
using CarRepair.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.CodeAnalysis.Host;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

// dil servisini ekledim
//builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
//builder.Services.Configure<RequestLocalizationOptions>(options =>
//{
//    var supportedCultures = new List<CultureInfo>
//    {
//        new CultureInfo("en-US"),
//        new CultureInfo("tr-TR")
//    };
//    options.DefaultRequestCulture = new RequestCulture("tr-TR");
//    options.SupportedCultures = supportedCultures;
//    options.SupportedUICultures = supportedCultures;

//    options.RequestCultureProviders = new List<IRequestCultureProvider>
//    {
//        new QueryStringRequestCultureProvider(),
//        new CookieRequestCultureProvider(),
//        new AcceptLanguageHeaderRequestCultureProvider()
//    };

//});



builder.Services.AddSingleton<LanguageService>();
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.AddMvc()
    .AddViewLocalization()
    .AddDataAnnotationsLocalization(options =>
    {
        options.DataAnnotationLocalizerProvider = (type, factory) =>
        {
            var assemblyName = new AssemblyName(typeof(ShareResource).GetTypeInfo().Assembly.FullName);
            return factory.Create("ShareResource", assemblyName.Name);
        };
    });

builder.Services.Configure<RequestLocalizationOptions>(
    options =>
    {
        var supportedCultures = new List<CultureInfo>
        {
               new CultureInfo("en-US"),
                           new CultureInfo("tr-TR"),
        };

        options.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "en-US");
        options.SupportedCultures = supportedCultures;
        options.SupportedUICultures = supportedCultures;

        options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());
    });







var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//var options = app.ApplicationServices.GetServices<IOptions<RequestLocalizationOptions>>()

//var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
//app.UseRequestLocalization(options.Value);


var options = ((IApplicationBuilder)app).ApplicationServices.GetRequiredService<IOptions<RequestLocalizationOptions>>();

app.UseRequestLocalization(options.Value);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
