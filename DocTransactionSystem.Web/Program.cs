using DocTransactionSystem.Data;
using DocTransactionSystem.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// إضافة EF Core (In Memory DB)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("DocTransactionsDB"));

// إضافة Repository
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Transaction}/{action=Index}/{id?}");

app.Run();