using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MySportShope.API.Context;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MainContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("MainDB"));
});

// Add services to the container.

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
        ValidAudience = builder.Configuration["Authentication:Audience "],
        ValidIssuer = builder.Configuration["Authentication::Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["Authentication:Secret"]))
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
