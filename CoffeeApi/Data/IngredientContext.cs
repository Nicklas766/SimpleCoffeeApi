#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoffeeApi.Models;

    public class IngredientContext : DbContext
    {
        public IngredientContext (DbContextOptions<IngredientContext> options)
            : base(options)
        {
        }

        public DbSet<CoffeeApi.Models.Ingredient> Ingredient { get; set; }
    }
