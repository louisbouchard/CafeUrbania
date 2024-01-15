using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using CafeUrbania.Models.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7110/") });
builder.Services.AddScoped<IMenuService, MenuService>();

builder.Services.AddBlazorise()
  .AddBootstrapProviders()
  .AddFontAwesomeIcons();

await builder.Build().RunAsync();
