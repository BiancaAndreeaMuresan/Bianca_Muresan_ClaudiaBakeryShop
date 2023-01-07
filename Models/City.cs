namespace Bianca_Muresan_ClaudiaBakeryShop.Models
{
    public class City
    {
        public int ID { get; set; }
        public string CityName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
