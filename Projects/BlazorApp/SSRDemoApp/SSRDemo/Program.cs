using SSRDemo.Components;
//Default for ASP.NET Core
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//INJECTION Of Razor Components (DEPENDANCY INJECTIONS)
builder.Services.AddRazorComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//REDIRECT Sites to HTTPS Protocol
app.UseHttpsRedirection();
//INJECTING CSS,JS,IMAGES, BOOTSTRAP Files
app.UseStaticFiles();
//Check for FORM Submisison, ie, it is submitted my human only
app.UseAntiforgery();
//Defines/Directs the APP LOCATION
app.MapRazorComponents<App>();
//RUNS the APP
app.Run();
