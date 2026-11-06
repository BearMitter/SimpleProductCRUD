using Microsoft.AspNetCore.Mvc;
using SimpleProductCRUD.Data;
using SimpleProductCRUD.Models;

namespace SimpleProductCRUD.Controllers;

public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Json(_context.Products.ToList());
    }

    [HttpGet]
    public IActionResult GetById(int id)
    {
        return Json(_context.Products.Find(id));
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        product.CreatedDate = DateTime.Now;

        _context.Products.Add(product);
        _context.SaveChanges();

        return Json(new { success = true });
    }

    [HttpPost]
    public IActionResult Update(Product product)
    {
        var existingProduct = _context.Products.Find(product.Id);

        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;

            _context.SaveChanges();
        }

        return Json(new { success = true });
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        var product = _context.Products.Find(id);

        if (product != null)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        return Json(new { success = true });
    }
}
