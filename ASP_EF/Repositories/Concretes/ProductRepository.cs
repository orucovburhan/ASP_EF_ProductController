using ASP_EF.Datas;
using ASP_EF.Models;
using ASP_EF.Repositories.Concretes;

public class ProductRepository
    : BaseRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context)
        : base(context) { }
}
