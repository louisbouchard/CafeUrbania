using CafeUrbania.Models.Services;
using CafeUrbania.Models;
using Microsoft.AspNetCore.Components;

namespace CafeUrbania.UI.Admin
{
    public partial class OrderHistory
    {
        [Inject]
        public IOrderService OrderService { get; set; }

        public List<Order> Orders { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Orders = (await OrderService.GetOrders()).ToList();
        }
    }
}
