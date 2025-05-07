using FrontBackTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontBackTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            Product product= new Product()
            {
                Id = 1,
                Name = "Tulpan",
                Price=15,
                Description="",
                ImageUrl="shop-10-img.jpg"

            }; Product product1= new Product()
            {
                Id = 1,
                Name = "Tulpan",
                Price=15,
                Description="",
                ImageUrl="shop-10-img.jpg"

            }; Product product2= new Product()
            {
                Id = 1,
                Name = "Tulpan",
                Price=15,
                Description="",
                ImageUrl="shop-10-img.jpg"

            }; Product product3= new Product()
            {
                Id = 1,
                Name = "Tulpan",
                Price=15,
                Description="",
                ImageUrl="shop-10-img.jpg"

            }; Product product4= new Product()
            {
                Id = 1,
                Name = "Tulpan",
                Price=15,
                Description="",
                ImageUrl="shop-10-img.jpg"

            };

            products.Add(product);
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);

            return View(products);
        }


       

    }
}
