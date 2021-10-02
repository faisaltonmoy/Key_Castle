using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle_DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Key_Castle_Models.Buyer> Buyer { get; set; }
        public DbSet<Key_Castle_Models.Buyer_Profile> Buyer_Profile { get; set; }
        public DbSet<Key_Castle_Models.Seller> Seller { get; set; }
        public DbSet<Key_Castle_Models.Seller_Profile> Seller_Profile { get; set; }
        public DbSet<Key_Castle_Models.Admin> Admin { get; set; }
        public DbSet<Key_Castle_Models.Cart> Cart { get; set; }
        public DbSet<Key_Castle_Models.Category> Category { get; set; }
        public DbSet<Key_Castle_Models.Order> Order { get; set; }
        public DbSet<Key_Castle_Models.Order_Details> Order_Details { get; set; }
        public DbSet<Key_Castle_Models.Payment> Payment { get; set; }
        public DbSet<Key_Castle_Models.Product> Product { get; set; }
        public DbSet<Key_Castle_Models.AppUser> AppUser { get; set; }

    }
}
 