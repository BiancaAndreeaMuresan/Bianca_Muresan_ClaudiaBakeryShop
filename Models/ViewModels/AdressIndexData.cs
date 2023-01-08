using System.Security.Policy;
namespace Bianca_Muresan_ClaudiaBakeryShop.Models.ViewModels
{
    public class AdressIndexData
    {
        public IEnumerable<Adress> Adresses { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
