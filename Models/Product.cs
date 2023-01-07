using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Bianca_Muresan_ClaudiaBakeryShop.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpireDate { get; set; }
        public int? AdressID { get; set; }
        public Adress? Adress { get; set; }
        public int? QuantityID { get; set; }
        public Quantity? Quantity { get; set; }
        public int? CityID { get; set; }
        public City? City { get; set; }
        public ICollection<ProductCategory>? ProductCategories { get; set; }


    }
}
