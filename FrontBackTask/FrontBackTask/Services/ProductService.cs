using FrontBackTask.Contexts;
using FrontBackTask.Models;

namespace FrontBackTask.Services
{
    public class ProductService
    {

        private readonly ProductDbContext _context;
       
        public ProductService()
        {
            _context = new ProductDbContext();
        }


        public void CreateProduct(Product product)
        {
            _context.products.Add(product);
            _context.SaveChanges(); 
        }

        public Product? GetProductById(int id) 
        {
            Product? product = _context.products.Find(id);
            return product;
        }

        public List<Product> GetProducts() {
            List<Product> productsList = _context.products.ToList();
            return productsList; 
        }

        public void DeleteProduct(int id) {

            Product? product = _context.products.Find(id);

            if (product is null)
            {
                throw new Exception("Product is not found");
            }
            _context.Remove(product);
            _context.SaveChanges();

        }

        public void UpdateProduct(int id,Product p) {
        Product? product = _context.products.Find(id);

            if (product is null)
            {
                throw new Exception("Product is not found");
            }

            product.Price = p.Price;
            product.Description = p.Description;
            product.Name = p.Name;
            product.ImageUrl = p.ImageUrl;

            _context.SaveChanges();

        }



    }
}
