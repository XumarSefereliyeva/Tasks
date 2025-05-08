using FrontBackTask.Models;
using FrontBackTask.Services;
using Microsoft.AspNetCore.Mvc;

namespace FrontBackTask.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        ProductService productservice = new ProductService();

        [HttpPost]
        public IActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product) 
        {
            productservice.CreateProduct(product);
            return View(productservice);
        }
        [HttpGet]
        public IActionResult GetProduct()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetProduct(int id)
        {
         Product? p=   productservice.GetProductById(id);
            return View(p);
        }
        [HttpGet]
        public IActionResult GetProducts() 
        {
             List<Product>  products = productservice.GetProducts();
            return View(products);
        }
        [HttpPost]
        public IActionResult Delete()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            productservice.DeleteProduct(id);
            return View();
        }
        [HttpPost]
        public IActionResult Updata()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Updata(int id,Product product)
        {
            productservice.UpdateProduct(id, product);  
            return View(product);
        }

    }
}
