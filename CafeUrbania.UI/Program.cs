using Blazorise;
using CafeUrbania.Client.Components;
using CafeUrbania.Models.Services;
using CafeUrbania.UI.Components;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using CafeUrbania.UI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBlazorise()
  .AddBootstrapProviders()
  .AddFontAwesomeIcons();

builder.Services.AddHttpClient();
builder.Services.AddHttpClient<IMenuPopulaireService, MenuPopulaireService>(client =>
    client.BaseAddress = new Uri("https://localhost:7110/"));
builder.Services.AddHttpClient<IContactService, ContactService>(client =>
    client.BaseAddress = new Uri("https://localhost:7110/"));
builder.Services.AddHttpClient<IOrderService, OrderService>(client =>
    client.BaseAddress = new Uri("https://localhost:7110/"));

builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Order).Assembly);

app.Run();
