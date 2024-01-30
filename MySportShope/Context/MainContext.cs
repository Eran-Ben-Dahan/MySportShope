using Microsoft.EntityFrameworkCore;
using MySportShope.API.Models;
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
                new BoxSize { ID = 2, Height = 3, Length = 8, Weight = 3, Width = 4, ProductID = 2 },
                new BoxSize { ID = 3, Height = 1, Length = 10, Weight = 5, Width = 9, ProductID = 3 }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, Name = "Shoes", PersoneTypeID = 1 },
                new Category { ID = 2, Name = "Sportswear", PersoneTypeID = 1 }
                );
            modelBuilder.Entity<Client>().HasData(
                new Client { ID = 1, FirstName = "Eran", LastName = "Ben Dahan", Email = "eran0099@gmail.com", PhoneNumber = 0548050910 }//Add BDay
                );

            modelBuilder.Entity<Color>().HasData(
                new Color { ID = 1, Name = "Red" },
                new Color { ID = 2, Name = "yellow" }
                );

            //many to many
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Colors)
                .WithMany(c => c.Products)
                .UsingEntity<Dictionary<int, int>>(
                "ColorProduct",
                r => r.HasOne<Color>().WithMany().HasForeignKey("ColorsID"),
                l => l.HasOne<Product>().WithMany().HasForeignKey("ProductID"),
                j =>
                {
                    j.HasKey("ColorsID", "ProductID");
                    j.HasData(
                        new { ProductID = 1, ColorsID = 1 },
                        new { ProductID = 1, ColorsID = 2 }
                        );
                }
                );

            modelBuilder.Entity<Image>().HasData(
                new Image { ID = 1, ProductID = 1, Name = "Sport Shoes ", Title = "Shoes", URL = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/88c3280a-1b77-4cf9-957f-d71b91e90393/revolution-6-road-running-shoes-sP4fgd.png", Alt = "Black Sport Shoes ", Description = "A beautiful and comfortable shoe" }
                );

            modelBuilder.Entity<ItemSize>().HasData(
                new ItemSize { ID = 1, SizeName = "49", ProductID = 1 }
                );
            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { ID = 1, OrdersID = 1, productID = 1, Price = 25.5, Quantity = 2 },
                new OrderItem { ID = 2, OrdersID = 1, productID = 2, Price = 25.5, Quantity = 2 },
                new OrderItem { ID = 3, OrdersID = 2, productID = 2, Price = 25.5, Quantity = 2 }
                );
            modelBuilder.Entity<Orders>().HasData(
                new Orders { ID = 1, ClientID = 1, ShippingAddresID = 1, PaymentID = 1, OrderDate = DateTime.Now, SpecialDiscount = 0 },
                new Orders { ID = 2, ClientID = 1, ShippingAddresID = 1, PaymentID = 1, OrderDate = DateTime.Now, SpecialDiscount = 0 }
                );

            modelBuilder.Entity<Payment>().HasData(
                new Payment { ID = 1, CardCvv = 123, CardMonth = 02, CardNumber = 134456775, CardYear = 2024, PaymentDate = DateTime.Now }
                );
            modelBuilder.Entity<PersoneType>().HasData(

                new PersoneType { ID = 1, Name = "Men" },
                new PersoneType { ID = 2, Name = "Women" },
                new PersoneType { ID = 3, Name = "Kids" },
                new PersoneType { ID = 4, Name = "Men & Women" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ID = 1, Name = "Sport Shoes ", Manufacturer = "Nike", SubCategoryID = 1, PersoneTypeID = 1, Description = "A beautiful and comfortable shoe"},
                new Product { ID = 2, Name = "Sport Tshert ", Manufacturer = "Nike", SubCategoryID = 1, PersoneTypeID = 1, Description = "Butebull Tshert"},
                new Product { ID = 3, Name = "Ball ", Manufacturer = "Nike", SubCategoryID = 1, PersoneTypeID = 1, Description = "Ball" }
                );

            modelBuilder.Entity<ShippingAddres>().HasData(
                new ShippingAddres { ID = 1, Building = 13, City = "Netanya", Country = "Israel", House = 5, StreetName = "Rotem", Zip = 5677 }
                );

            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory { ID = 1, CategoryID = 1, Name = "Running shoes" },
                new SubCategory { ID = 2, CategoryID = 1, Name = "Basketball shoes" }
            );
         
        }
    }
}
