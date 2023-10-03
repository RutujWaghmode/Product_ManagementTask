using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product_ManagementTask.Models;
using Product_ManagementTask.Services;

namespace Product_ManagementTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductWebApiController : ControllerBase
    {
        IProductServices ProductService;
        public ProductWebApiController(IProductServices ProductService)
        {
            this.ProductService = ProductService;
        }

        [HttpGet]
        [Route("GetProducts")]
        public List<TblProduct> GetProducts()
        {
            try
            {
                return ProductService.GetAllProducts();
            }
            catch(Exception) 
            {
                throw new Exception("Error Occurred");
            }

        }
            
        [HttpGet]
        [Route("product/{id}")]
        public TblProduct GetProduct(int id)
        {
            try
            {
                return ProductService.GetProduct(id);
            }
            catch(Exception)
            {
                throw new Exception("Error Occured !");
            }
        }

        [HttpPost]
        [Route("AddProduct")]
        public string AddProduct([FromBody] TblProduct Product)
        {
                try
                {
                    if(ModelState.IsValid) { 

                    ProductService.AddProduct(Product);
                    return "Product Added Sucessfully";
                }
                    return "Failed to add Product";
                
                }
                catch (Exception ex)
                {
                    return $"Error Adding Product: {ex.Message}";
                }
            
        }

        [HttpPut]
        [Route("UpdateProduct")]
        public string UpdateProduct([FromBody] TblProduct Product)
        {
            try
            {
                ProductService.UpdateProduct(Product);
                return "Product Updated Sucessfully";
            }
            catch(Exception ex)
            {
                return $"Error Updated Product: {ex.Message}";
            }

        }

        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public string DeleteProduct(int id)
        {
            
            try
            {
                ProductService.DeleteProduct(id);
                return "Product Deleted Sucessfully";
            }
            catch(Exception ex)
            {
                return $"Error Deleted Product: {ex.Message}";
            }
        }
    }
}

