
using CafeUrbania.Models;

namespace CafeUrbania.MinApi.Services.Interfaces;

public interface IMenuService
{
    List<MenuItem> GetMenuItems();
}