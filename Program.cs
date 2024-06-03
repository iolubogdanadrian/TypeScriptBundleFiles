var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddBundling()
    .UseDefaults(builder.Environment)
    .AddEcmaScript();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseBundling(
    bundles =>
    {
        bundles.AddJs("/BoostrapperExample.js")
            .Include("/js/BoostrapperExample.js")
            .EnableEs6ModuleBundling();
    });

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
