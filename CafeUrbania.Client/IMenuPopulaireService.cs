namespace CafeUrbania.Models.Services;

public interface IMenuPopulaireService
{
    Task<List<MenuItem>> GetMenuItems();

    List<MenuItem> GetPopularItems();
}
