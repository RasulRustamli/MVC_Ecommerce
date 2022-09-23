using Microsoft.EntityFrameworkCore;
using MVC_TemplateApp.Models;
using System;

namespace MVC_TemplateApp.Data
{
    public class MVC_Ecommerce : DbContext
    {
        public MVC_Ecommerce(DbContextOptions options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
    }
}
