using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using EFCoreExample.Services;
using Microsoft.AspNetCore.Mvc;



namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        //This appdbcontext is used to interact with our database


        //private readonly AppDbContext _context;


        /*public ProfilesController(AppDbContext context)
        {
            _context = context;
        }  */


        private readonly IProductService _productService;
      public ProductsController(IProductService productService)
      {
        _productService = productService;
      }



        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
           var profiles = _productService.GetAllProducts(); 
           return Ok(profiles);
        }


        //added
         [HttpGet("{ProductId}")]
        public ActionResult<ProductDTO> GetProductById(int ProductId)
        {

             var product = _productService.GetProductById(ProductId);
            return product;

        }








         [HttpPost]
        public ActionResult<ProductDTO> PostProduct(ProductDTO productDto)
        {

            var product = _productService.CreateProduct(productDto);
            return CreatedAtAction(nameof(GetProductById), new { ProductId = product.ProductId }, productDto);

            
            
        }



        
        //added
        [HttpPut("{ProductId}")]
        public ActionResult<ProfileDTO> UpdateProduct(int ProductId, ProductDTO UpdatedProduct)
        {

            _productService.UpdateProduct(ProductId, UpdatedProduct);
            return Ok(UpdatedProduct);


            /*
            var profile = _context.Profiles.FirstOrDefault(p => p.ProfileId == ProfileId);

            profile.Bio = UpdatedProfile.Bio;

            _context.Profiles.Update(profile);
            _context.SaveChanges();

            return Ok(UpdatedProfile); */
        }
        

        
            //added
            [HttpDelete("{ProductId}")]
        public IActionResult DeleteProduct(int ProductId)
        {

             _productService.DeleteProduct(ProductId);
            return Ok();
            /*
            var profile = _context.Profiles.FirstOrDefault(p => p.ProfileId == ProfileId);
            _context.Profiles.Remove(profile);
            _context.SaveChanges();

            return Ok(); */
        }

    }
}