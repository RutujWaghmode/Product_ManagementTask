using Microsoft.EntityFrameworkCore;
using Product_ManagementTask.Services;
namespace Product_ManagementTask.Models
{
    public class ProductDBContext:DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {


        }
        public DbSet<TblProduct> Products { get; set; }
    }
}

