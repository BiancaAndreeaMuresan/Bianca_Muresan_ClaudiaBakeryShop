using System.Security.Policy;
namespace Bianca_Muresan_ClaudiaBakeryShop.Models.ViewModels
{
    public class CityIndexData
    {
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
