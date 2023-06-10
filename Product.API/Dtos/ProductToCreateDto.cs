using System.ComponentModel.DataAnnotations;

namespace Product.API.Dtos
{
    public class ProductToCreateDto
    {
        [Required(ErrorMessage ="Product Name Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Product Descrption Is Required")]
        public string Description { get; set; }


        public double Price { get; set; }
    }
}
