using System.Net.Http.Json;

namespace CafeUrbania.Models.Services;

public class MenuService : IMenuService
{
    private readonly HttpClient http;

    public MenuService(HttpClient http)
    {
        this.http = http;
    }

    public async Task<List<MenuItem>> GetMenuItems()
    {
        var menuItems = await http.GetFromJsonAsync<MenuItem[]>("menu");
        return menuItems.ToList();
    }

    public List<MenuItem> GetPopularItems()
    {
        return new List<MenuItem>()
        {
            new MenuItem()
            {
                Name = "Mocha Latté",
                ShortDescription = "Moitié café, moitié pur délice - la tempête parfaite."
            },
            new MenuItem()
            {
                Name = "Café à la fraise",
                ShortDescription = "Un mélange divin avec un goût de fraîcheur"
            },
            new MenuItem()
            {
                Name = "Chocolat chaud à la menthe",
                ShortDescription = "Tellement bon, il fait froid dehors et vous serez réconforté."
            },
            new MenuItem()
            {
                Name = "Thé vert",
                ShortDescription = "Un classique qui a ses raisons"
            }
        };
    }
}
