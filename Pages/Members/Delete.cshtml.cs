using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bianca_Muresan_ClaudiaBakeryShop.Data;
using Bianca_Muresan_ClaudiaBakeryShop.Models;

namespace Bianca_Muresan_ClaudiaBakeryShop.Pages.Members
{
    public class DeleteModel : PageModel
    {
        private readonly Bianca_Muresan_ClaudiaBakeryShop.Data.Bianca_Muresan_ClaudiaBakeryShopContext _context;

        public DeleteModel(Bianca_Muresan_ClaudiaBakeryShop.Data.Bianca_Muresan_ClaudiaBakeryShopContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Member Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Member == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FirstOrDefaultAsync(m => m.ID == id);

            if (member == null)
            {
                return NotFound();
            }
            else 
            {
                Member = member;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Member == null)
            {
                return NotFound();
            }
            var member = await _context.Member.FindAsync(id);

            if (member != null)
            {
                Member = member;
                _context.Member.Remove(Member);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
