using BlazorTest.Components;
using BlazorTest.Components.Classes.Interfaces;
using BlazorTest.Components.Classes.Lists;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//Added Singleton Services
builder.Services.AddSingleton<IActivities, ListActivity>();
builder.Services.AddSingleton<IEducators, ListEducator>();
builder.Services.AddSingleton<ICategories, ListCategory>();
builder.Services.AddSingleton<IFields, ListField>();
builder.Services.AddSingleton<ISubjects, ListSubject>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
