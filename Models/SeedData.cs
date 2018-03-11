using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Kayak", Description = "A boat for one person", Category = "Watersprots", Price = 275 },
                    new Product { Name = "Lifejacket", Description = "Protective and fashionable", Category = "Watersports", Price = 48.95m },
                    new Product { Name = "Soccer Ball", Description = "FIFA approved size and weight", Category = "Soccer", Price = 19.50m },
                    new Product { Name = "Corner flags", Description = "Give a professional touch", Category = "Soccer", Price = 79500 },
                    new Product { Name = "Thinking Cap", Description = "Improve brain efficiency by 75%", Category = "Chess", Price = 29.95m },
                    new Product { Name = "Unsteady chair", Description = "Secretly give a disadvantage", Category = "Chess", Price = 29.95m },
                    new Product { Name = "Human chess board", Description = "A fun game for the family", Category = "Chess", Price = 75 },
                    new Product { Name = "Bling-bling King", Description = "Gold-plated, diomond-studded King", Category = "Chess", Price = 1200 });
                context.SaveChanges();
            }
        }
    }
}
