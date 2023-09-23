using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MySportShope.API.Context;
using MySportShope.API.Repositories;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MainContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("MainDB"));
});

// Add services to the container.
builder.Services.AddScoped<IBoxSizeRepository, BoxSizeRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IColorRepository, ColorRepository>();
builder.Services.AddScoped<IImageRepository, ImageRepository>();
builder.Services.AddScoped<IItemSizeRepository, ItemSizeRepository>();
builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>();
builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<IPersoneTypeRepository, PersoneTypeRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IShippingAddresRepository, ShippingAddresRepository>();
builder.Services.AddScoped<ISubCategoryRepository, SubCategoryRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication("Bearer").AddJwtBearer(o =>

{
    o.TokenValidationParameters = new()
    {
        ValidateIssuer = false,//Make it true
        ValidateAudience = false,//Make it true
        ValidateIssuerSigningKey = true,
        ValidAudience = builder.Configuration["Authentication:Audience "] ?? throw new ArgumentException("Authentication:Audience"),
        ValidIssuer = builder.Configuration["Authentication::Issuer"] ?? throw new ArgumentException("Authentication:Issuer"),
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["Authentication:Secret"] ?? throw new ArgumentException("Authentication:Secret")))
    };
});

var app = builder.Build();

//This code makes sure the DB is up to data evry time the API starts
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<MainContext>();
    context.Database.Migrate();
}


// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
