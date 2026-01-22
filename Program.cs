using BlazorTest.Components;
using BlazorTest.Components.Classes;
using BlazorTest.Components.Classes.Interfaces;
using BlazorTest.Components.Classes.Lists;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//Added Singleton Services
builder.Services.AddSingleton<IActivities, ListActivity>();
builder.Services.AddSingleton<IEducators, ListEducatorsTest>();
builder.Services.AddSingleton<ICategories, ListCategoryTest>();
builder.Services.AddSingleton<IFields, ListFieldsTest>();
builder.Services.AddSingleton<ISubjects, ListSubjectsTest>();
builder.Services.AddSingleton<Subject>(); //Controll and fix this 

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
