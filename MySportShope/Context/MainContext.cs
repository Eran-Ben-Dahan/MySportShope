using Microsoft.EntityFrameworkCore;
using MySportShope.API.Models.DTO;
using MySportShope.API.Models.Enums;

namespace MySportShope.API.Context
{
    public class MainContext:DbContext
    {
        public MainContext(DbContextOptions<MainContext> options):base(options) 
        {
           
        }
        public DbSet<BoxSize> BoxSizes { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Orders> Orderss { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShippingAddres> ShippingAddres { get; set; }
        public DbSet<ItemSize> Sizes { get; set; }
        public DbSet<SubCategory> SubCategorys { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
