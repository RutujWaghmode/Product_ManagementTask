using System.ComponentModel.DataAnnotations;

namespace Product_ManagementTask.Models
{
    public class TblProduct
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        public string ProductName { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Product price must be a non-negative value.")]
        public float ProductPrice { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Product stock must be a non-negative value.")]
        public int ProductStock { get; set; }

        [Required(ErrorMessage="Description is Required.")]
        public string Description { get; set; }

        [Range(0, 5, ErrorMessage = "Product rate must be between 0 and 5.")]
        public float ProductRate { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Product tax must be a non-negative value.")]
        public float ProductTax { get; set; }

    }
}
