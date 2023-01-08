using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bianca_Muresan_ClaudiaBakeryShop.Models;

namespace Bianca_Muresan_ClaudiaBakeryShop.Data
{
    public class Bianca_Muresan_ClaudiaBakeryShopContext : DbContext
    {
        public Bianca_Muresan_ClaudiaBakeryShopContext (DbContextOptions<Bianca_Muresan_ClaudiaBakeryShopContext> options)
            : base(options)
        {
        }

        public DbSet<Bianca_Muresan_ClaudiaBakeryShop.Models.Product> Product { get; set; } = default!;

        public DbSet<Bianca_Muresan_ClaudiaBakeryShop.Models.City> City { get; set; }

        public DbSet<Bianca_Muresan_ClaudiaBakeryShop.Models.Adress> Adress { get; set; }

        public DbSet<Bianca_Muresan_ClaudiaBakeryShop.Models.Quantity> Quantity { get; set; }

        public DbSet<Bianca_Muresan_ClaudiaBakeryShop.Models.Category> Category { get; set; }

        public DbSet<Bianca_Muresan_ClaudiaBakeryShop.Models.Member> Member { get; set; }

        public DbSet<Bianca_Muresan_ClaudiaBakeryShop.Models.Cart> Cart { get; set; }
    }
}
