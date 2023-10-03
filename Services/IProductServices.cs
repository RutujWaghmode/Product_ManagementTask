using Product_ManagementTask.Models;

namespace Product_ManagementTask.Services
{
    public interface IProductServices
    {
        void AddProduct(TblProduct Product);
        void UpdateProduct(TblProduct Product);
        void DeleteProduct(int ProductId);
        List<TblProduct> GetAllProducts();
        TblProduct GetProduct(int PId);
    }
}
