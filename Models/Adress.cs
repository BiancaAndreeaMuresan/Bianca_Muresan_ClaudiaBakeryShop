namespace Bianca_Muresan_ClaudiaBakeryShop.Models
{
    public class Adress
    {
        public int ID { get; set; }
        public string AdressName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
