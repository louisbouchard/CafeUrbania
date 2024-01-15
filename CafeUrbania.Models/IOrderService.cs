namespace CafeUrbania.Models.Services;

public interface IOrderService
{
    Task<List<Order>> GetOrders();
}