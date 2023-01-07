using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bianca_Muresan_ClaudiaBakeryShop.Data;
using Bianca_Muresan_ClaudiaBakeryShop.Models;

namespace Bianca_Muresan_ClaudiaBakeryShop.Pages.Quantities
{
    public class DeleteModel : PageModel
    {
        private readonly Bianca_Muresan_ClaudiaBakeryShop.Data.Bianca_Muresan_ClaudiaBakeryShopContext _context;

        public DeleteModel(Bianca_Muresan_ClaudiaBakeryShop.Data.Bianca_Muresan_ClaudiaBakeryShopContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Quantity Quantity { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Quantity == null)
            {
                return NotFound();
            }

            var quantity = await _context.Quantity.FirstOrDefaultAsync(m => m.ID == id);

            if (quantity == null)
            {
                return NotFound();
            }
            else 
            {
                Quantity = quantity;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Quantity == null)
            {
                return NotFound();
            }
            var quantity = await _context.Quantity.FindAsync(id);

            if (quantity != null)
            {
                Quantity = quantity;
                _context.Quantity.Remove(Quantity);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
