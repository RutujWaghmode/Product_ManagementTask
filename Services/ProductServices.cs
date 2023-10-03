using Product_ManagementTask.Models;

namespace Product_ManagementTask.Services
{
    public class ProductServices:IProductServices
    {
        private ProductDBContext _ProductContext;
        public ProductServices(ProductDBContext productContext)
        {
            _ProductContext = productContext;
        }

        public void AddProduct(TblProduct Product)
        {
            _ProductContext.Add(Product);
            _ProductContext.SaveChanges();
        }

        public void DeleteProduct(int ProductId)
        {
            var Product = _ProductContext.Products.FirstOrDefault(p => p.ProductId == ProductId);
            if (Product != null)
            {
                _ProductContext.Products.Remove(Product);

                _ProductContext.SaveChanges();
            }
            else
            {
                throw new Exception("Product Not Found!");
            }
        }

        public List<TblProduct> GetAllProducts()
        {
            return _ProductContext.Products.ToList();
        }

        public TblProduct GetProduct(int PId)
        {
            return _ProductContext.Find<TblProduct>(PId);
        }

        public void UpdateProduct(TblProduct Product)
        {
            _ProductContext.Update(Product);
            _ProductContext.SaveChanges();
        }
    }
}
