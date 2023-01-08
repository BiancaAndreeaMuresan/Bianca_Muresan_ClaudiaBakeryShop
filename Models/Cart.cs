using System.ComponentModel.DataAnnotations;

namespace Bianca_Muresan_ClaudiaBakeryShop.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public int? MemberID { get; set; }
        public Member? Member { get; set; }
        public int? ProductID { get; set; }
        public Product? Product { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
    }
}
