using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bianca_Muresan_ClaudiaBakeryShop.Data;
using Bianca_Muresan_ClaudiaBakeryShop.Models;
using Bianca_Muresan_ClaudiaBakeryShop.Models.ViewModels;
using System.Security.Policy;

namespace Bianca_Muresan_ClaudiaBakeryShop.Pages.Cities
{
    public class IndexModel : PageModel
    {
        private readonly Bianca_Muresan_ClaudiaBakeryShop.Data.Bianca_Muresan_ClaudiaBakeryShopContext _context;

        public IndexModel(Bianca_Muresan_ClaudiaBakeryShop.Data.Bianca_Muresan_ClaudiaBakeryShopContext context)
        {
            _context = context;
        }

        public IList<City> City { get;set; } = default!;
        public CityIndexData CityData { get; set; }
        public int CityID { get; set; }
        public async Task OnGetAsync(int? id, int? productID)
        {
            CityData = new CityIndexData();
            CityData.Cities = await _context.City
            .Include(i => i.Products)
            .OrderBy(i => i.CityName)
            .ToListAsync();
            if (id != null)
            {
                CityID = id.Value;
                City city = CityData.Cities
                .Where(i => i.ID == id.Value).Single();
                CityData.Products = city.Products;
            }
        }
    }
}
