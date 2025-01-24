using Domain.Models.Purchases;

namespace Domain.IRepositories
{
    public interface IOrderRepository : IRepositoryBase<Order>
    {
        public List<Order> GetOrdersWithDetails(int clientId);
        public List<Order> GetAllOrdersWithDetails();

    }
}
