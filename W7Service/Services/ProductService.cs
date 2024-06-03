using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;

namespace EFCoreExample.Services
{
    public class ProductService : IProductService
    {
         private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }



          public Product CreateProduct(ProductDTO ProductDto)
        {
            if (ValidateNewProduct(ProductDto))
            {
                var product = new Product
                {
                    Name = ProductDto.Name,
                    Price = ProductDto.Price,
                    CategoryName = ProductDto.CategoryName


                };
                _context.Products.Add(product);
                _context.SaveChanges();

                return product;
            }  else
            {
                throw new Exception("Invalid Profile");
            }
        }


          private bool ValidateNewProfile(ProductDTO ProductDto)
        {
            if(ProductDto.Name.Trim().Length ==0){
                return false;
            }else return true;
        }


         public void DeleteProduct(int ProductId)
        {
            var product = _context.Users.FirstOrDefault(u => u.UserId == ProductId);
        }

       
         public IEnumerable<ProductDTO> GetAllProducts()
        {
           var products = _context.Products
                 .Select(p => new ProductDTO
                {
                    Name = p.Name,
                    Price = p.Price,
                    CategoryName = p.Category.Name
                }).ToList();
                return products;
        }



          public ProductDTO GetProductById(int ProductId)
        {
           var product = _context.Products.Find(ProductId);
           var productDto = new ProductDTO
            {
                Name = product.Name,
                Price = product.Price,
                CategoryName = product.Category.Name
            };
            return productDto;
        }



           public void UpdateProduct(int ProductId, ProductDTO UpdatedProduct)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == ProductId);

            product.Name = UpdatedProduct.Name;
            //product.Price = UpdateProduct.Price;
            //product.Category.Name = UpdateProduct.CategoryName;

            _context.Products.Update(product);
            _context.SaveChanges();
        }

       
    }
}