

using ISellLaptops.Data;
using ISellLaptops.Models;
using Microsoft.EntityFrameworkCore;

using LaptopsContext context = new LaptopsContext();

//make the data
/*

Brand cheese = new()
{
    Name = "Cheese Wikipedia"
};
context.Brands.Add(cheese);

Brand CrapCo = new()
{
    Name = "CrapCo"
};
context.Brands.Add(CrapCo);

Brand CTOAN = new()
{
    Name = "CTOAN"
};
context.Brands.Add(CTOAN);

Brand Expensove = new()
{
    Name = "Expensove"
};
context.Brands.Add(Expensove);

Laptop CheeseWheel = new()
{
    Name = "Cheese Wheel 8",
    Price = 160.99M,
    Year = 2020,
    Brand = cheese,
    Description = "This is our experimental round PC, Is not edible; do not consume"
};
context.Laptops.Add(CheeseWheel);

Laptop PunchCard = new()
{
    Name = "Punch Card Reader",
    Price = 12.99M,
    Year = 1967,
    Brand = CrapCo,
    Description = "This machine reads punchcards. Punchcards sold seperately"
};
context.Laptops.Add(PunchCard);

Laptop AFHE3G256KMP_27_X = new()
{
    Name = "AFHE3G256KMP 27 X",
    Price = 4864.12M,
    Year = 2023,
    Brand = Expensove,
    Description = "11th Gen Intel® Core™ i5-1145G7, vPro® (8 MB cache, 4 cores, 8 threads, 2.60 GHz to 4.00 GHz Turbo), 8 GB, LPDDR4x, 4266 MHz, integrated, 256 GB, M.2, PCIe NVMe, SSD, Class 35"
};
context.Laptops.Add(AFHE3G256KMP_27_X);

Laptop CTOAN_1 = new()
{
    Name = "CTOAN 1",
    Price = 1036.57M,
    Year = 2021,
    Brand = CTOAN,
    Description = "A decent Laptop"
};
context.Laptops.Add(CTOAN_1);

Laptop GigaLaptop = new()
{
    Name = "The Giga-Laptop",
    Price = 35.99M,
    Year = 1987,
    Brand = CrapCo,
    Description = "This is probably not a laptop. Must be plugged in at all times or it will explode. Don't explode or your money back!"
};
context.Laptops.Add(GigaLaptop);

Laptop CTOAN_2 = new()
{
    Name = "CTOAN 2",
    Price = 1170.59M,
    Year = 2022,
    Brand = CTOAN,
    Description = "Just like the first but it's faster and lighter. Now comes in Gold color"
};
context.Laptops.Add(CTOAN_2);

Laptop GTX500HD67JKLOL_7_Pro = new()
{
    Name = "GTX500HD67JKLOL 7 Pro",
    Price = 9754.97M,
    Year = 2037,
    Brand = Expensove,
    Description = "20th Gen Intel® Core™ i7-1246G8, vPro® (8 GB cache, 6 cores, 80 threads, 4.60 GHz to 6.00 GHz Turbo), 8 TB, LPDDR4x, 4266 MHz, integrated, 16 TB, M.2, PCIe NVMe, SSD, Class 37"
};
context.Laptops.Add(GTX500HD67JKLOL_7_Pro);

Laptop Slice = new()
{
    Name = "Cheddar Slice",
    Price = 2045.97M,
    Year = 2023,
    Brand = cheese,
    Description = "Our newest Laptop thin and extremely flexible. Comes in Yellow, White, Red, and Blue-Cheese. Not edible; do not consume"
};
context.Laptops.Add(Slice);

Laptop QuantumCheese = new()
{
    Name = "Quantum Cheese",
    Price = 1056752.97M,
    Year = 3481,
    Brand = cheese,
    Description = "Our laptop from the future. Can answer your questions 27 minutes before you ask them. Can simulate the universe. Edible; possible side effects include nausea, hallucinations, blindness, being able to see the future, and dying before you were born. Consumption not recommended"
};
context.Laptops.Add(QuantumCheese);

context.SaveChanges();

//*/


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<LaptopsContext>(options => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ThereBeLaptops;Integrated Security=True;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Laptops}/{action=Index}/{id?}");

app.Run();
