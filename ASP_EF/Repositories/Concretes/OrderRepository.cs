using ASP_EF.Datas;
using ASP_EF.Models;
using ASP_EF.Repositories.Concretes;

public class OrderRepository
    : BaseRepository<Order>, IOrderRepository
{
    public OrderRepository(AppDbContext context)
        : base(context) { }
}
