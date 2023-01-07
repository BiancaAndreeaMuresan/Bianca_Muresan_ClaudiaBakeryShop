namespace Bianca_Muresan_ClaudiaBakeryShop.Models
{
    public class Quantity
    {
        public int ID { get; set; }
        public string QuantityName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
