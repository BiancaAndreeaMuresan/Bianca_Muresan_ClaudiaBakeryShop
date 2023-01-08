using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bianca_Muresan_ClaudiaBakeryShop.Data;
using Bianca_Muresan_ClaudiaBakeryShop.Models;

namespace Bianca_Muresan_ClaudiaBakeryShop.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Bianca_Muresan_ClaudiaBakeryShop.Data.Bianca_Muresan_ClaudiaBakeryShopContext _context;

        public IndexModel(Bianca_Muresan_ClaudiaBakeryShop.Data.Bianca_Muresan_ClaudiaBakeryShopContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; } = default!;
        public ProductData ProductD { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string NameSort { get; set; }
        public string CurrentFilter { get; set; }

        public async Task OnGetAsync(int? id, int? categoryID, string sortOrder, string
searchString)
        {
            ProductD = new ProductData();

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";


            CurrentFilter = searchString;

            ProductD.Products = await _context.Product
            .Include(b => b.Adress)
            .Include(b => b.Quantity)
            .Include(b => b.City)
            .Include(b => b.ProductCategories)
            .ThenInclude(b => b.Category)
            .AsNoTracking()
            .OrderBy(b => b.Name)
            .ToListAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                ProductD.Products = ProductD.Products.Where(s => s.Name.Contains(searchString));
            }


            if (id != null)
            {
                ProductID = id.Value;
                Product product = ProductD.Products
                .Where(i => i.ID == id.Value).Single();
                ProductD.Categories = product.ProductCategories.Select(s => s.Category);
            }
            switch (sortOrder)
            {
                case "name_desc":
                    ProductD.Products = ProductD.Products.OrderByDescending(s =>
                    s.Name);
                    break;
            }
        }
    }
}
