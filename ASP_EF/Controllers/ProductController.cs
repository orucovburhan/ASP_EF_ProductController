using ASP_EF.Models;
using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    private readonly IProductRepository _repo;

    public ProductController(IProductRepository repo)
    {
        _repo = repo;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _repo.GetAllAsync());
    }

    public async Task<IActionResult> Details(int id)
    {
        return View(await _repo.GetByIdAsync(id));
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Product product)
    {
        await _repo.AddAsync(product);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _repo.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }
}
