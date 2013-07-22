using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<News> news { set; get; }
        public DbSet<Category> categories { set; get; }
        public DbSet<File> files { set; get; }
        public DbSet<Company> companies { set; get; }
        public DbSet<Product> products { set; get; }
        public DbSet<Paragon> paragons { set; get; }
        public DbSet<Founder> founders { set; get; }
    }
}