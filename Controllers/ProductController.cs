using catalogsample.Models;
using Microsoft.AspNetCore.Mvc;

namespace catalogsample.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private static List<Product> products = new List<Product>();

    static ProductController()
    {
        products.Add(new Product{
            Id = 1,
            DisplayName = "Margherita",
            Description = "Classic delight with 100% real mozzarella cheese",
            Crust = "New Hand Tossed, 100% wheat thin crust, Cheese Burst, Fresh Pan Pizza",
            Size = "Regular, Medium, Large"
        });

        products.Add(new Product{
            Id = 2,
            DisplayName = "Farmhouse",
            Description = "Delightful combination of onion, capsicum, tomato & grilled mushroom",
            Crust = "New Hand Tossed, 100% wheat thin crust, Cheese Burst, Fresh Pan Pizza",
            Size = "Regular, Medium, Large"
        });

        products.Add(new Product{
            Id = 3,
            DisplayName = "Peppy Paneer",
            Description = "Flavorful trio of juicy paneer, crisp capsicum with spicy red paprika",
            Crust = "New Hand Tossed, 100% wheat thin crust, Cheese Burst, Fresh Pan Pizza",
            Size = "Regular, Medium, Large"
        });
    }

    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;

    }

    [HttpGet(Name = "GetProduct")]
    public IEnumerable<Product> Get()
    {
        return products.ToArray();
    }

    [HttpPost(Name = "PostProduct")]
    public IActionResult Submit(Product product)
    {
        int newId = products.Max(p => p.Id) + 1;
        product.Id = newId;
        products.Add(product);
        return Ok();
    }
}
