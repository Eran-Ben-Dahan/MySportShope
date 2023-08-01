using Microsoft.EntityFrameworkCore;
using MySportShope.API.Models.DTO;
using MySportShope.API.Models.Enums;

namespace MySportShope.API.Context
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

        }
        public DbSet<BoxSize> BoxSizes { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Orders> Orderss { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShippingAddres> ShippingAddres { get; set; }
        public DbSet<ItemSize> Sizes { get; set; }
        public DbSet<SubCategory> SubCategorys { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PersoneType> PersoneTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User { ID = 1, Username = "Eran", Password = "1234", LastLogin = DateTime.Now, Type = UserType.Admin }
                );

            modelBuilder.Entity<BoxSize>().HasData(
                new BoxSize { ID = 1, Height = 2.5, Length = 10, Weight = 5, Width = 5, ProductID = 1 },
                new BoxSize { ID =2, Height = 3, Length = 8, Weight = 3, Width = 4, ProductID = 2 },
                new BoxSize { ID = 3, Height = 1, Length = 10, Weight = 5, Width = 9, ProductID = 3 }
                );

            modelBuilder.Entity<Client>().HasData(
                new Client { ID = 1, FirstName = "Eran", LastName = "Ben Dahan", Email = "eran0099@gmail.com", PhoneNumber = 0548050910,UserID=1}//Add BDay
                );
            //Many to many
            modelBuilder.Entity<Color>().HasData(
                new Color { ID = 1,Name="Black"},
                new Color { ID = 2,Name= "yellow" },
                new Color { ID = 13,Name= "orange" }
            )
        }
    }
}
