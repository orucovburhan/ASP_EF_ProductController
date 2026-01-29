using ASP_EF.Datas;
using ASP_EF.Models;
using ASP_EF.Repositories.Concretes;

public class CategoryRepository
    : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context)
        : base(context) { }
}
