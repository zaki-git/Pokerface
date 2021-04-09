using Microsoft.EntityFrameworkCore;
using Pokerface.Domain.Models.CategoryModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokerface.Repository.DataAccess
{
    public class PokerfaceContext : DbContext
    {
        public PokerfaceContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
